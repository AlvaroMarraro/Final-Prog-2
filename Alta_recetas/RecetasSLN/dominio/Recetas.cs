using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    class Recetas
    {
       
        public int RecetaNro { get; set; }
        public string Nombre { get; set; }
        public string Cheff { get; set; }
        public int TipoReceta { get; set; }

        public DateTime Fecha { get; set; }

        public List<DetalleRecetas> Detalles { get; set; }

        public Recetas()
        {
            Detalles = new List<DetalleRecetas>();
        }
        public void AgregarDetalle(DetalleRecetas detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }



        public Recetas(int recetaNro, string nombre, string cheff, int tipoReceta)
        {
            RecetaNro = recetaNro;
            Nombre = nombre;
            Cheff = cheff;
            TipoReceta = tipoReceta;
        }
    }
}
