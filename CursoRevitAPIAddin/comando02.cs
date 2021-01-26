using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace CursoRevitAPIAddin
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class comando02 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Variables basicas que pueden servirnos de Revit
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //TaskDialog.Show("Titulo", doc.Title);

            //Seleccionar Elementos Por ID
            ElementId idd = new ElementId(428745);
            Element elem = doc.GetElement(idd);
            //TaskDialog.Show("Titulo", elem.Category.Name);

            //Seleccion de Elementos por Filtros
            FilteredElementCollector colector = new FilteredElementCollector(doc);
            //--------Seleccionar todos los muros de mi proyecto
            /*colector.OfCategory(BuiltInCategory.OST_Walls);
            colector.WhereElementIsNotElementType();*/
            colector.OfClass(typeof(Wall));


            Form1 frmm = new Form1(doc);
            frmm.ShowDialog();



            //TaskDialog.Show("Titulo", "Hay un total de " + colector.Count() + " muros");




            //Seleccion actual de Elementos




            //Seleccion durante la ejecucion


            return Result.Succeeded;
        }
    }
}
