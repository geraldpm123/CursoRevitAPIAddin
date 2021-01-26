
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1(Document doc)
        {
            InitializeComponent();
            //Seleccion de Elementos por Filtros
            FilteredElementCollector colector = new FilteredElementCollector(doc);
            //--------Seleccionar todos los muros de mi proyecto
            colector.OfCategory(BuiltInCategory.OST_Walls);
            colector.WhereElementIsElementType();

            StringBuilder sb = new StringBuilder();
            foreach (Element ele in colector)
            {
                sb.AppendLine(ele.Name);
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
