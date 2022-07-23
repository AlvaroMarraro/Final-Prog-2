using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final140222.dominio
{
    class DetalleRecurso

    {
        public Empleado Empleado { get; set; }
        public Proyecto Proyecto { get; set; }
        public string Rol { get; set; }
        public int HrsSemana { get; set; }

        public DetalleRecurso(Empleado empleadoId, Proyecto proyectoId, string rol, int hrsSemana)
        {
            Empleado = empleadoId;
            Proyecto = proyectoId;
            Rol = rol;
            HrsSemana = hrsSemana;
        }

        public DetalleRecurso()
        {
            Proyecto = new Proyecto();
            Empleado = new Empleado();
            Rol = "";
            HrsSemana = 0;
        }
    }
}


