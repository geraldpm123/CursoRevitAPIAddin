using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Autodesk.Revit.UI;

namespace CursoRevitAPIAddin
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class App : IExternalApplication
    {
        private string _ruta = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public Result OnStartup(UIControlledApplication application)
        {
            //Codigo que se carga al momento de abRIR Revit
            //Añadir una pestaña o tab a Revit
            application.CreateRibbonTab("Pestaña 1");
            //Crear in panel dentro del tab
            RibbonPanel panel1 = application.CreateRibbonPanel("Pestaña 1", "Grupo 1");
            //Crearemos los botones con sus imagenes respectivas y asignacion de comandos
            PushButton boton0 = panel1.AddItem(new PushButtonData("boton0", "Comando uno", _ruta, "CursoRevitAPIAddin.comando01")) as PushButton;
            Uri uriImage0 = new Uri("pack://application:,,,/CursoRevitAPIAddin;component/Resources/Columna3x32.png");
            boton0.LargeImage = new BitmapImage(uriImage0);
            boton0.ToolTip = "Este es el comando 1";
            boton0.LongDescription = "Y esta es la descripcion larga del boton";

            PushButton boton1 = panel1.AddItem(new PushButtonData("boton1", "Comando dosss", _ruta, "CursoRevitAPIAddin.comando02")) as PushButton;
            Uri uriImage1 = new Uri("pack://application:,,,/CursoRevitAPIAddin;component/Resources/files2.png");
            boton1.LargeImage = new BitmapImage(uriImage1);
            boton1.ToolTip = "Este es el comando 2";
            boton1.LongDescription = "Y esta es la descripcion larga del boton 2";

            PushButton boton2 = panel1.AddItem(new PushButtonData("boton2", "Comando tres", _ruta, "CursoRevitAPIAddin.comando03")) as PushButton;
            Uri uriImage2 = new Uri("pack://application:,,,/CursoRevitAPIAddin;component/Resources/fire2.png");
            boton2.LargeImage = new BitmapImage(uriImage2);
            boton2.ToolTip = "Este es el comando 3";
            boton2.LongDescription = "Y esta es la descripcion larga del boton 3";

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        
    }
}
