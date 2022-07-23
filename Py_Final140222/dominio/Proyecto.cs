using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final140222.dominio
{
    class Proyecto
   
    {
        public int ProyectoId { get; set; }
        public string Nombre { get; set; }
        public DateTime fechaInicio{ get; set; }
        public DateTime fechaFin { get; set; }

        public List<DetalleRecurso> Detalles { get; set; }

        public Proyecto(int proyectoId, string nombre, DateTime fechaInicio, DateTime fechaFin)
        {
            ProyectoId = proyectoId;
            Nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }

        public Proyecto()
        {
            Detalles = new List<DetalleRecurso>();
        }

        public void AgregarDetalle(DetalleRecurso detalle) 
        {
            Detalles.Add(detalle);
        
        }

        public void QuitarDetalle(int indice) 
        {

            Detalles.RemoveAt(indice);
        
        }

        public void FinalizarProyecto() 
        {
            this.fechaFin = DateTime.Today;
        
        }

        public int TotalProyectos() 
        {
            List<Proyecto> proyecto = new List<Proyecto>();
            int total = 0;
            foreach (Proyecto item in proyecto)
            {
                total++;
            }
            return total;
        }

        public string GetFechaBajaFormato()
        {
            string aux = fechaFin.ToString("dd/MM/yyyy");
            return aux.Equals("01/01/0001") ? "" : aux;
        }
    }
}


