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
    class comando11 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Variables basicas que pueden servirnos de Revit
            UIApplication uiApp = commandData.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            //Pedir al usuario que seleccione un elemento
            Reference reff = uiDoc.Selection.PickObject(ObjectType.Element, "Seleccione un muro");
            Element elemento = doc.GetElement(reff);

            IList<GeometryObject> solidos = new List<GeometryObject>();

            Wall muro = elemento as Wall;
            if (muro != null)
            {
                Options opt = new Options();
                opt.DetailLevel = ViewDetailLevel.Coarse;

                GeometryElement geoElem = muro.get_Geometry(opt);

                foreach (GeometryObject geomObj in geoElem)
                {
                    Solid geomSolid = geomObj as Solid;
                    if (geomSolid!=null)
                    {
                        solidos.Add(geomSolid);
                    }
                }
            }

            //Crear el DirectShape
            Transaction t = new Transaction(doc, "Create sphere direct shape");
            t.Start();
            // create direct shape and assign the sphere shape
            DirectShape ds = DirectShape.CreateElement(doc, new ElementId(BuiltInCategory.OST_GenericModel));

            ds.ApplicationId = "Application id2";
            ds.ApplicationDataId = "Geometry object id2";
            ds.SetShape(solidos);
            t.Commit();



            return Result.Succeeded;
        }
    }
}
