using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class DetalleRecetas
    {
       
        public Ingredientes Ingredientes { get; set; }
        public double Cantidad { get; set; }

        public DetalleRecetas()
        {

        }
        public DetalleRecetas(Ingredientes ingredientes, double cantidad)
        {
            Ingredientes = ingredientes;
            Cantidad = cantidad;
        }


    }




}
