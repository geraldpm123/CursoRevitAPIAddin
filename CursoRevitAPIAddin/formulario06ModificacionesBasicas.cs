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
    public partial class formulario06ModificacionesBasicas : System.Windows.Forms.Form
    {
        private Element _elem;
        private Document _doc;
        private CurveElement _linea;
        public formulario06ModificacionesBasicas(Element elem,Element linea)
        {
            InitializeComponent();
            _elem = elem;
            _doc = elem.Document;
            _linea = linea as CurveElement;
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            XYZ vectorTraslacion = new XYZ(10, 0, 0);
            Transaction t = new Transaction(_doc, "Mover Elementos");
            t.Start();
            ElementTransformUtils.MoveElement(_doc, _elem.Id, vectorTraslacion);
            t.Commit();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            //XYZ vectorTraslacion = new XYZ(0, 10, 0);
            Line lineaaa = _linea.GeometryCurve as Line;
            XYZ vectorTraslacion = lineaaa.Origin + lineaaa.Direction.Multiply(lineaaa.Length);

            Transaction t = new Transaction(_doc, "Copiar Elementos");
            t.Start();
            //IList<ElementId> IDS = new List<ElementId>();
            //IDS.Add()
            ElementTransformUtils.CopyElement(_doc, _elem.Id, vectorTraslacion);
            t.Commit();
        }

        private void btnRotar_Click(object sender, EventArgs e)
        {
            double angulo = 0.524;
            XYZ point1 = new XYZ(10, 20, 0);
            XYZ point2 = new XYZ(10, 20, 30);
            Line ejeRotacion = Line.CreateBound(point1, point2);
            Transaction t = new Transaction(_doc, "Rotar Elementos");
            t.Start();
            ElementTransformUtils.RotateElement(_doc,_elem.Id,ejeRotacion,angulo);
            t.Commit();
        }

        private void btnReflejar_Click(object sender, EventArgs e)
        {
            XYZ normal = new XYZ(1, 0, 0);
            XYZ origen = new XYZ(-5, 0, 0);
            Plane pl = Plane.CreateByNormalAndOrigin(normal, origen);
            Transaction t = new Transaction(_doc, "Reflejar Elemento");
            t.Start();
            ElementTransformUtils.MirrorElement(_doc, _elem.Id, pl);
            t.Commit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction(_doc, "Borrar Elemento");
            t.Start();
            _doc.Delete(_elem.Id);
            t.Commit();
        }
    }
}
