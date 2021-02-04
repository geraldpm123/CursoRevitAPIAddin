using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace CursoRevitAPIAddin
{
    public partial class formulario05ParametrosCompartidos : System.Windows.Forms.Form
    {
        private UIApplication _uiApp;
        private Autodesk.Revit.ApplicationServices.Application _app;
        private Document _doc;
        public formulario05ParametrosCompartidos(UIApplication uiApp)
        {
            InitializeComponent();
            _uiApp = uiApp;
            _app = uiApp.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            _doc = uiDoc.Document;
            //Acceder al archivo por defecto de parametros compartidos
            DefinitionFile parametrosCompartidos = _app.OpenSharedParameterFile();
            DefinitionGroups grupos = parametrosCompartidos.Groups;
            //LLenar el combobox Grupos
            cmbGrupos.DataSource = grupos.ToList();
            cmbGrupos.DisplayMember = "Name";

        }

        private void cmbGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtenga la seleccion del grupo del usuario
            DefinitionGroup grupoSeleccionado = cmbGrupos.SelectedItem as DefinitionGroup;
            //Rellena el combo bozx de Parametros
            cmbParametros.DataSource = grupoSeleccionado.Definitions.ToList();
            cmbParametros.DisplayMember = "Name";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Agrupacion donde se colocara el parametro
            BuiltInParameterGroup agrupacion = BuiltInParameterGroup.PG_TEXT;
            //Listado de categorias
            CategorySet categorias = _app.Create.NewCategorySet();
            categorias.Insert(Category.GetCategory(_doc, BuiltInCategory.OST_Walls));
            //Crear el parametro compartido en el proyecto
            Definition parametro = cmbParametros.SelectedItem as Definition;
            Transaction t = new Transaction(_doc, "Creacion del parametro compartido");
            t.Start();
            InstanceBinding bb = _app.Create.NewInstanceBinding(categorias);
            _doc.ParameterBindings.Insert(parametro, bb, agrupacion);
            t.Commit();
            TaskDialog.Show("Parametro Creado", "Se ha creado el parametro compartido con exito", TaskDialogCommonButtons.Ok);
        }
    }
}
