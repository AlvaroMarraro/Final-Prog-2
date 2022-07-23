using Py_Final030222.Servicios;
using Py_Final140222.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final030222.datos
{
    interface IProyectoDao
    {
        List<Proyecto> ConsultarPresupuestos();
        Proyecto ConsultarUnProyecto(int nroProyecto);
        bool FinalizarProyecto(int nroPresupuesto);
        List<Proyecto> ConsultarProyectosFiltros(List<Parametro> filtros);
    }
}
