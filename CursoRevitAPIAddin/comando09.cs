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
    class comando09 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Variables basicas que pueden servirnos de Revit
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //Seleccion de curvas o lienas de modelo
            List<Reference> sel = uiDoc.Selection.PickObjects(ObjectType.Element, "Seleccione lineas de modelo").ToList();

            List<ModelCurve> curvas = new List<ModelCurve>();
            foreach (Reference reference in sel)
            {
                ModelCurve curva = doc.GetElement(reference) as ModelCurve;
                if (curva!=null)
                {
                    curvas.Add(curva);
                }
            }

            formulario09CreacionFrames frm = new formulario09CreacionFrames(doc,curvas);
            frm.ShowDialog();

            return Result.Succeeded;
        }
    }
}
