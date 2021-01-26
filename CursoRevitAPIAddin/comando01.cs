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
    public class comando01 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Aca va el codigo que ejecutara el comando en revit
            TaskDialog.Show("Titulo de mi mensaje", "HOLA MUNDO, DE NUEVO LES MANDO UN SALUDO");

            //Instanciar y mostrar el formulario
            furmulario01 frm = new furmulario01();
            frm.ShowDialog();

            return Result.Succeeded;
        }
    }
}
