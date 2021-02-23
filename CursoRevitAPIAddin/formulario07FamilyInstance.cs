using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using ClosedXML.Excel;

namespace CursoRevitAPIAddin
{
    public partial class formulario07FamilyInstance : System.Windows.Forms.Form
    {
        Document _doc;
        FamilySymbol _symSeleccionado;
        int _n;
        public formulario07FamilyInstance(Document doc)
        {
            InitializeComponent();
            _doc = doc;
            //Rellenar comboCategorias
            cmbCategorias.DataSource = Tools.ObtenerCategoriasDelModelo(_doc);
            cmbCategorias.DisplayMember = "Name";
            //Rellenar comboNiveles
            cmbNiveles.DataSource = Tools.ObtenerListaNiveles(_doc);
            cmbNiveles.DisplayMember = "Name";
        }


        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category catSeleccionada = cmbCategorias.SelectedItem as Category;
            List<FamilySymbol> tipos = Tools.ObtenerFamilySymbolPorCategoria(_doc, catSeleccionada);
            IList<FamilySymbol> tipos2 = new List<FamilySymbol>();
            foreach (FamilySymbol tipo in tipos)
            {
                tipos2.Add(tipo);
            }

            if (tipos.Count!=0)
            {
                cmbTipos.DataSource = tipos2;
                cmbTipos.DisplayMember = "Name";
                cmbTipos.Enabled = true;
                btnColocarEjemplares.Enabled = true;
            }
            else
            {
                IList<FamilySymbol> tipos3 = new List<FamilySymbol>();
                cmbTipos.DataSource = tipos3;
                cmbTipos.Enabled = false;
                btnColocarEjemplares.Enabled = false;
                picImagenDeTipo.BackgroundImage = null;
            }

            
        }


        #region Funcionalidad Interfaz Grafica
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            dgvCoordenadas.Rows.Add();
        }
        private void dgvCoordenadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _n = e.RowIndex;
            RellenarLabelFilaSeleccionada();
            
        }
        private void RellenarLabelFilaSeleccionada()
        {
            if (_n != -1)
            {
                lblFila.Text = "Fila sel: " + (_n + 1);
            }
            else
            {
                lblFila.Text = "";
            }
        }
        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (_n!=-1)
            {
                dgvCoordenadas.Rows.RemoveAt(_n);
                int numeroFilas = dgvCoordenadas.Rows.Count;
                if (_n + 1 > numeroFilas)
                {
                    _n = _n - 1;
                }
            }
            RellenarLabelFilaSeleccionada();
            
        }

        #endregion

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            _symSeleccionado = cmbTipos.SelectedItem as FamilySymbol;
            picImagenDeTipo.BackgroundImage = _symSeleccionado.GetPreviewImage(new Size(156, 156));
        }

        private void btnColocarEjemplares_Click(object sender, EventArgs e)
        {
            Level nivelSeleccionado = cmbNiveles.SelectedItem as Level;
            //Recuperar las coordenadas que el usuario ingreso
            List<XYZ> listaPuntos = new List<XYZ>();
            for (int i = 0; i < dgvCoordenadas.Rows.Count; i++)
            {
                try
                {
                    double x = Convert.ToDouble(dgvCoordenadas.Rows[i].Cells[0].Value.ToString());
                    double y = Convert.ToDouble(dgvCoordenadas.Rows[i].Cells[1].Value.ToString());
                    double z = Convert.ToDouble(dgvCoordenadas.Rows[i].Cells[2].Value.ToString());
                    XYZ posicion = new XYZ(
                    UnitUtils.ConvertToInternalUnits(x, DisplayUnitType.DUT_METERS),
                    UnitUtils.ConvertToInternalUnits(y, DisplayUnitType.DUT_METERS),
                    UnitUtils.ConvertToInternalUnits(z, DisplayUnitType.DUT_METERS));
                    listaPuntos.Add(posicion);
                }
                catch (Exception eee)
                {
                    MessageBox.Show("No se han ingresado las posiciones correctamente" + "\n" + eee.Message);
                    return;
                } 
            }

            if (listaPuntos.Count!=0)
            {
                Transaction t = new Transaction(_doc, "Creacion de FamilyInstance");
                t.Start();
                foreach (XYZ xYZ in listaPuntos)
                {
                    _doc.Create.NewFamilyInstance(xYZ, _symSeleccionado, nivelSeleccionado, Autodesk.Revit.DB.Structure.StructuralType.NonStructural);

                }
                t.Commit();
                MessageBox.Show("Se ha creado con exito los elementos en las posiciones indicadas", "Proceso exitoso");
            }
            else
            {
                MessageBox.Show("No se han ingresado valores de ubicacion para colocar los elementos", "Proceso fallido");
            }


        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo CSV (*.csv)|*.csv";
            save.FileName = _doc.Title + " - Coordenadas.csv";
            if (save.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    rutaArchivo = save.FileName;
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("X(m),Y(m),Z(m)");
                    for (int i = 0; i < dgvCoordenadas.Rows.Count; i++)
                    {
                        string x = dgvCoordenadas.Rows[i].Cells[0].Value.ToString();
                        string y = dgvCoordenadas.Rows[i].Cells[1].Value.ToString();
                        string z = dgvCoordenadas.Rows[i].Cells[2].Value.ToString();
                        sb.AppendLine(x + "," + y + "," + z);
                    }
                    File.WriteAllText(rutaArchivo, sb.ToString());
                    MessageBox.Show("Archivo guardado correctamente", "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo crear el archivo. Error: " + ex.Message, "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnImportarCSV_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivo CSV (*.csv)|*.csv";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaArchivo = open.FileName;
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    string[] lineas2 = lineas.Skip(1).ToArray();
                    //dgvCoordenadas.Rows.Clear();
                    for (int i = 0; i < lineas2.Length; i++)
                    {
                        string[] valores = Regex.Split(lineas2[i], ",");
                        double x = Convert.ToDouble(valores[0]);
                        double y = Convert.ToDouble(valores[1]);
                        double z = Convert.ToDouble(valores[2]);
                        //Añadir los valores al datagridview
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.Cells.Add(new DataGridViewTextBoxCell());
                        fila.Cells.Add(new DataGridViewTextBoxCell());
                        fila.Cells.Add(new DataGridViewTextBoxCell());
                        fila.Cells[0].Value = x;
                        fila.Cells[1].Value = y;
                        fila.Cells[2].Value = z;
                        //Añadimos la fila al datagridView
                        dgvCoordenadas.Rows.Add(fila);
                    }

                    MessageBox.Show("Datos importados correctamente", "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo importar los datos. Error: " + ex.Message, "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            save.FileName = _doc.Title + " - Coordenadas.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaArchivo = save.FileName;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("X(m)");
                    dt.Columns.Add("Y(m)");
                    dt.Columns.Add("Z(m)");
                    for (int i = 0; i < dgvCoordenadas.Rows.Count; i++)
                    {
                        dt.Rows.Add();
                    }
                    //Crear el libro de excel y añadimos una hoja
                    XLWorkbook book = new XLWorkbook();
                    book.AddWorksheet(dt, "Coordenadas");
                    //Obtener la hoja que hemos creado
                    var ws = book.Worksheet(1);
                    int fila = 2;

                    for (int i = 0; i < dgvCoordenadas.Rows.Count; i++)
                    {
                        string x = dgvCoordenadas.Rows[i].Cells[0].Value.ToString();
                        string y = dgvCoordenadas.Rows[i].Cells[1].Value.ToString();
                        string z = dgvCoordenadas.Rows[i].Cells[2].Value.ToString();
                        ws.Cell(fila, 1).Value = x;
                        ws.Cell(fila, 2).Value = y;
                        ws.Cell(fila, 3).Value = z;
                        fila++;
                    }
                    //Guardar Excel
                    book.SaveAs(rutaArchivo);


                    MessageBox.Show("Archivo guardado correctamente", "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo crear el archivo. Error: " + ex.Message, "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaArchivo = open.FileName;
                    var libro = new XLWorkbook(rutaArchivo);
                    var hoja = libro.Worksheet(1);
                    //dgvCoordenadas.Rows.Clear();
                    foreach (var row in hoja.Rows())
                    {
                        try
                        {
                            double x = Convert.ToDouble(row.Cell(1).Value.ToString());
                            double y = Convert.ToDouble(row.Cell(2).Value.ToString());
                            double z = Convert.ToDouble(row.Cell(3).Value.ToString());
                            //Añadir los valores al datagridview
                            DataGridViewRow fila = new DataGridViewRow();
                            fila.Cells.Add(new DataGridViewTextBoxCell());
                            fila.Cells.Add(new DataGridViewTextBoxCell());
                            fila.Cells.Add(new DataGridViewTextBoxCell());
                            fila.Cells[0].Value = x;
                            fila.Cells[1].Value = y;
                            fila.Cells[2].Value = z;
                            //Añadimos la fila al datagridView
                            dgvCoordenadas.Rows.Add(fila);
                        }
                        catch (Exception)
                        {
                        }
                    }

                    MessageBox.Show("Datos importados correctamente", "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo importar los datos. Error: " + ex.Message, "Revit",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
