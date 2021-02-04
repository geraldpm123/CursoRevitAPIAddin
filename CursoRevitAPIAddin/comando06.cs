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
    class comando06 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Variables basicas que pueden servirnos de Revit
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //Obtener la referencia a seleccionar
            Reference reff = uiDoc.Selection.PickObject(ObjectType.Element, "Seleccione un elemento por favor");
            Reference reff2 = uiDoc.Selection.PickObject(ObjectType.Element, "Seleccione un modelLine");
            Element elemento = doc.GetElement(reff);
            Element linea = doc.GetElement(reff2);

            //Llamar al formulario
            formulario06ModificacionesBasicas frm = new formulario06ModificacionesBasicas(elemento,linea);
            frm.ShowDialog();


            return Result.Succeeded;
        }
    }
}
