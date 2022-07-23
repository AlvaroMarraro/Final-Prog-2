using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFinal.Entidades
{
    public class DetallePresupuesto
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

        public DetallePresupuesto(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public DetallePresupuesto()
        {
            Producto = null;
            Cantidad = 0;
        }

        public double CalcularSubtotal() 
        {
            return Producto.Precio * Cantidad;
        
        }
    }
}
