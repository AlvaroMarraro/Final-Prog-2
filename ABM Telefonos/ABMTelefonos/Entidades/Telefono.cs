using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Entidades
{
    class Telefono
    {
        public int Codigo { get; set; }
        public string  Nombre { get; set; }
        public int Marca { get; set; }
        public double Precio { get; set; }

        public Telefono(int codigo, string nombre, int marca, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
        }

        public Telefono()
        {
            Codigo = 0;
            Nombre = "";
            Marca = 0;
            Precio = 0;
        }
    }
}
