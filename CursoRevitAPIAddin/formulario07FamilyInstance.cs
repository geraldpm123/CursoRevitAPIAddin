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
    }
}
