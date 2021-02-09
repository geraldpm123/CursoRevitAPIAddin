
using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoRevitAPIAddin
{
    public partial class formulario09CreacionFrames : System.Windows.Forms.Form
    {
        Document _doc;
        List<ModelCurve> _listaCurvas;
        public formulario09CreacionFrames(Document doc,List<ModelCurve> listaCurvas )
        {
            InitializeComponent();
            _doc = doc;
            _listaCurvas = listaCurvas;
            //Llenar comboBoxTipo
            FilteredElementCollector col = new FilteredElementCollector(_doc);
            col.OfCategory(BuiltInCategory.OST_StructuralFraming);
            col.WhereElementIsElementType();
            List<FamilySymbol> tipos = new List<FamilySymbol>();
            foreach (Element element in col)
            {
                tipos.Add(element as FamilySymbol);
            }
            cmbTipos.DataSource = tipos;
            cmbTipos.DisplayMember = "Name";
            //Rellenar Niveles
            cmbNiveles.DataSource = Tools.ObtenerListaNiveles(_doc);
            cmbNiveles.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FamilySymbol tipo = cmbTipos.SelectedItem as FamilySymbol;
            Level nivel = cmbNiveles.SelectedItem as Level;
            Transaction t = new Transaction(_doc, "Creacion de Frames");
            t.Start();
            foreach (ModelCurve curve in _listaCurvas)
            {
                LocationCurve cc = curve.Location as LocationCurve;
                _doc.Create.NewFamilyInstance(cc.Curve, tipo, nivel, Autodesk.Revit.DB.Structure.StructuralType.Beam);
            } 
            t.Commit();
        }
    }
}
