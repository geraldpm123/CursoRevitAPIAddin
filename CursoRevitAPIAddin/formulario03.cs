
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
    public partial class formulario03 : System.Windows.Forms.Form
    {
        private Document _doc;
        public formulario03(Document doc)
        {
            InitializeComponent();
            _doc = doc;
            //Obtener las categorias del documento
            Categories categories = doc.Settings.Categories;
            List<Category> categorias = new List<Category>();
            foreach (Category cat in categories)
            {
                categorias.Add(cat);
            }
            //Llenar el combobox Categorias
            cmbCategorias.DataSource = categorias.OrderBy(x => x.Name).ToList();
            cmbCategorias.DisplayMember = "Name";
            //Inicializar uno de los radio butons
            rdbTipos.Checked = true;
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            LLenarDataGridView();
        }


        private void LLenarDataGridView()
        {
            //Obtener la seleccion del usuario
            //Category categoriaSeleccionada = cmbCategorias.SelectedItem as Category;
            Category categoriaSeleccionada = (Category)cmbCategorias.SelectedItem;
            BuiltInCategory bic = (BuiltInCategory)categoriaSeleccionada.Id.IntegerValue;

            //Filtrado de elementos
            FilteredElementCollector col = new FilteredElementCollector(_doc);
            if (rdbTipos.Checked)
            {
                col.WhereElementIsElementType();
            }
            if (rdbInstancias.Checked)
            {
                col.WhereElementIsNotElementType();
            }
            
            col.OfCategory(bic);

            //LLenar el DataGridView con los elementos obtenidos
            dgvElementos.Rows.Clear();
            foreach (Element ele in col)
            {
                //Creacion de una fila vacia
                DataGridViewRow row = new DataGridViewRow();
                //Crear la celda de ID
                DataGridViewTextBoxCell cellID = new DataGridViewTextBoxCell();
                cellID.Value = ele.Id.IntegerValue.ToString();
                row.Cells.Add(cellID);
                //Crear la celda de Nombre
                DataGridViewTextBoxCell cellNombre = new DataGridViewTextBoxCell();
                cellNombre.Value = ele.Name;
                row.Cells.Add(cellNombre);

                dgvElementos.Rows.Add(row);
            }
        }

        private void rdbTipos_CheckedChanged(object sender, EventArgs e)
        {
            LLenarDataGridView();
        }

        private void rdbInstancias_CheckedChanged(object sender, EventArgs e)
        {
            LLenarDataGridView();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
