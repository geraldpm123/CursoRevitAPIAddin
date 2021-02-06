using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;

namespace Tools
{
    public class Herramientas
    {
        public static List<Category> ObtenerCategoriasDelModelo(Document doc)
        {
            List<Category> categorias = new List<Category>();
            //Obtener las categorias del documento
            Categories categories = doc.Settings.Categories;
            foreach (Category cat in categories)
            {
                if (cat.CategoryType == CategoryType.Model)
                {
                    categorias.Add(cat);
                }
            }
            return categorias.OrderBy(x => x.Name).ToList();
        }

        public static List<FamilySymbol> ObtenerFamilySymbolPorCategoria(Document doc,Category categoria)
        {
            List<FamilySymbol> tipos = new List<FamilySymbol>();
            BuiltInCategory bic = (BuiltInCategory)categoria.Id.IntegerValue;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfCategory(bic);
            col.OfClass(typeof(FamilySymbol));
            foreach (Element element in col)
            {
                tipos.Add(element as FamilySymbol);
            }
            return tipos;
        }

        public static List<Level> ObtenerListaNiveles(Document doc)
        {
            List<Level> niveles = new List<Level>();
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfClass(typeof(Level));
            foreach (Element element in col)
            {
                niveles.Add(element as Level);
            }
            return niveles;
        }
    }
}
