using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace CursoRevitAPIAddin
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class comando04 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Variables basicas que pueden servirnos de Revit
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //Obtener la referencia a seleccionar
            Reference reff = uiDoc.Selection.PickObject(ObjectType.Element, "Seleccione un elemento por favor");
            //IList<Reference> reff = uiDoc.Selection.PickObjects(ObjectType.Element, "Seleccione elementos por favor");

            Element elemento = doc.GetElement(reff);
            TaskDialog.Show("Elemento seleccionado", "El id del elemento seleccionado es "+ elemento.Id);

            Form1 frm = new Form1(doc);
            frm.ShowDialog();

            return Result.Succeeded;
        }
    }
}
