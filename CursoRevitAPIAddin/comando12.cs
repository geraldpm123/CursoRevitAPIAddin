using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.DesignScript.Geometry;
using Revit.GeometryConversion;
using Revit.Elements;

namespace CursoRevitAPIAddin
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class comando12 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Variables basicas que pueden servirnos de Revit
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            Autodesk.DesignScript.Geometry.Point punto = Autodesk.DesignScript.Geometry.Point.ByCoordinates(0, 0, 0);
            Autodesk.DesignScript.Geometry.Sphere esfera1 = Autodesk.DesignScript.Geometry.Sphere.ByCenterPointRadius(punto, 5);

            IList<GeometryObject> solidos = esfera1.ToRevitType();
            
            using (Transaction t = new Transaction(doc, "Create sphere direct shape"))
            {
                t.Start();
                // create direct shape and assign the sphere shape
                Autodesk.Revit.DB.DirectShape ds = Autodesk.Revit.DB.DirectShape.CreateElement(doc, new ElementId(BuiltInCategory.OST_Walls));

                ds.ApplicationId = "Application id";
                ds.ApplicationDataId = "Geometry object id";
                ds.SetShape(solidos);
                t.Commit();
            }
            /*
            Autodesk.Revit.DB.Element elemRevit;
            Revit.Elements.Element elementDynamo = elemRevit.ToDSType(true);
            object[] geoms = elementDynamo.Geometry();
            elementDynamo.Solids*/
            return Result.Succeeded;
        }
    }
}
