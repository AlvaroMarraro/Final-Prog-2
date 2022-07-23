using Py_Final030222.datos;
using Py_Final140222.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final030222.Servicios
{
    class GestorProyecto
    {
        private IProyectoDao dao;

        public GestorProyecto(AbstractDaoFactory factory)
        {
            dao = factory.CrearProyectoDao();

        }

        internal List<Proyecto> CargarProyectos()
        {
            return dao.ConsultarPresupuestos();
        }

        internal Proyecto CargarProyectosPorNro(int nroProyecto)
        {
            return dao.ConsultarUnProyecto(nroProyecto);
        }

        internal bool BorrarProyecto(int nroPresupuesto)
        {
            return dao.FinalizarProyecto(nroPresupuesto);
        }

        internal List<Proyecto> CargarProyectoFiltros(List<Parametro> filtros)
        {
            return dao.ConsultarProyectosFiltros(filtros);
        }
    }
}
