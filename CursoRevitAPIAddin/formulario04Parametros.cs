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
    public partial class formulario04Parametros : System.Windows.Forms.Form
    {
        private Element _elem;
        private Document _doc;

        public formulario04Parametros(Element elem)
        {
            InitializeComponent();
            _elem = elem;
            _doc = elem.Document;
            //Leer los parametros comentarios y Marca del elemento
            Parameter paramComentarios = _elem.get_Parameter(BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS);
            txtComentarios.Text = paramComentarios.AsString();
            Parameter paramMarca = _elem.get_Parameter(BuiltInParameter.ALL_MODEL_MARK);
            txtMarca.Text = paramMarca.AsString();
            Parameter paramArea = _elem.get_Parameter(BuiltInParameter.HOST_AREA_COMPUTED);
            //Convertir el valor del area a otra unidad
            double valorConvertir = UnitUtils.ConvertFromInternalUnits(paramArea.AsDouble(), DisplayUnitType.DUT_SQUARE_METERS);
            txtArea.Text = (valorConvertir).ToString();
            //txtArea.Text = (paramArea.AsDouble()* 0.09290304).ToString();


            //Obtener los parametros del elemento
            ParameterSet parametros = _elem.Parameters;
            List<Definition> listaParametros = new List<Definition>();
            foreach (Parameter param in parametros)
            {
                listaParametros.Add(param.Definition);
            }
            //Llenar los parametros del elemento en el listBox
            lstBParametros.DataSource = listaParametros;
            lstBParametros.DisplayMember = "Name";

        }

        private void lstBParametros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Obtener el parametro seleccionado el usuario
            Definition deff = lstBParametros.SelectedItem as Definition;
            Parameter paramSeleccionado = _elem.get_Parameter(deff);
            //LLnear el valor del parametro

            //LLenar el tipo de parametro
            txtAlmacen.Text = paramSeleccionado.StorageType.ToString();
            //LLenar el metodo correspondiente AsString(), AsInteger(), AsDouble(), AsElementId()
            switch (paramSeleccionado.StorageType)
            {
                case StorageType.None:
                    //
                    
                    break;
                case StorageType.Integer:
                    //

                    break;
                case StorageType.Double:
                    //

                    break;
                case StorageType.String:
                    //

                    break;
                case StorageType.ElementId:
                    //

                    break;
                default:
                    break;
            }
 
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            Parameter paramComentarios = _elem.get_Parameter(BuiltInParameter.ALL_MODEL_INSTANCE_COMMENTS);
            //Transacciones hacerlas por recomendacion en un boton
            Transaction t = new Transaction(_doc, "Asignar el parametro comentarios");
            t.Start();
            paramComentarios.Set(txtComentarios.Text);

            t.Commit();
            MessageBox.Show("Se ha asignado el parametro");
        }
    }
}
