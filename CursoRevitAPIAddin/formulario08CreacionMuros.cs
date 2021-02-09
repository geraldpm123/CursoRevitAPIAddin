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
    public partial class formulario08CreacionMuros : System.Windows.Forms.Form
    {
        Document _doc;
        public formulario08CreacionMuros(Document doc)
        {
            InitializeComponent();
            _doc = doc;
            //Llenar los Tipos de muros
            FilteredElementCollector col = new FilteredElementCollector(_doc);
            col.OfClass(typeof(WallType));

            List<WallType> listaTiposMuro = new List<WallType>();
            foreach (Element element in col)
            {
                listaTiposMuro.Add(element as WallType);
            }

            cmbTiposMuros.DataSource = listaTiposMuro;
            cmbTiposMuros.DisplayMember = "Name";
            //Llenar los niveles
            cmbNiveles.DataSource = Tools.ObtenerListaNiveles(_doc);
            cmbNiveles.DisplayMember = "Name";
        }

        private void btnCrearMuro_Click(object sender, EventArgs e)
        {
            //Obtener las coordenadas ingresadas por el usuario
            XYZ p1 = new XYZ(
                Convert.ToDouble(txtX1.Text)/0.3048,
                Convert.ToDouble(txtY1.Text)/0.3048,
                0
                );
            XYZ p2 = new XYZ(
                Convert.ToDouble(txtX2.Text) / 0.3048,
                Convert.ToDouble(txtY2.Text) / 0.3048,
                0
                );
            Line linea = Line.CreateBound(p1, p2);
            //Obtener tipo y nivel del muro
            ElementId idTipo = (cmbTiposMuros.SelectedItem as WallType).Id;
            ElementId idNivel = (cmbNiveles.SelectedItem as Level).Id;
            Transaction t = new Transaction(_doc, "Creacion de muros");
            t.Start();
            Wall muro = Wall.Create(_doc, linea, idTipo, idNivel, 3/0.3048, 0, true, false);
            t.Commit();
            MessageBox.Show("Se ha creado el muro con exito");
            this.Close();
        }
    }
}
