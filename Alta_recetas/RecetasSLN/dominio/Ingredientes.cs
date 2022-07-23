using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Ingredientes
    {
        public int IngredientesId { get; set; }
        public string Nombre { get; set; }
        public string Unidad { get; set; }

        public Ingredientes()
        {

        }
        public Ingredientes(int ingredientesId, string nombre, string unidad)
        {
            IngredientesId = ingredientesId;
            Nombre = nombre;
            Unidad = unidad;
        }

       
    }
}
