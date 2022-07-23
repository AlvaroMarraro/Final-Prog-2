using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFinal.Entidades
{
    public class Producto
    {

        public int IdProducto { get; set; }
        public string NProducto { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }

        public Producto(int idProducto, string nProducto, double precio)
        {
            IdProducto = idProducto;
            NProducto = nProducto;
            Precio = precio;
            Activo = true;
        }


        public Producto()
        {
            IdProducto = 0;
            NProducto = string.Empty;
            Precio = 0;
            Activo = true;
        }

        public override string ToString()
        {
            return NProducto;
        }


    }
}
