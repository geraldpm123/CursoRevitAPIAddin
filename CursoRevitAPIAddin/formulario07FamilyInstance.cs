using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;

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
    }
}
