using PractiaFinal.AccesoDatos;
using PractiaFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFinal.Servicios
{
    class GestorPresupuesto
    {
        private IPresupuestoDao dao;

        public GestorPresupuesto(AbstractDaoFactory factory) 
        {
            dao = factory.CrearPresupuestoDao();
            
        }

        public Presupuesto CargarPresupuestoNro(int nroPresupuesto)
        {
            return dao.ConsultarUnPresupuesto(nroPresupuesto);

        }

        internal List<Producto> ObtenerProductos()
        {
            return dao.ConsultarProductos();
        }

        internal string ProximoPresupuesto()
        {
            return dao.ObtenerProximoNumero();
        }
    }
}
