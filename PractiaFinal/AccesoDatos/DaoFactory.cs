using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFinal.AccesoDatos
{
    class DaoFactory : AbstractDaoFactory
    {
        public override IPresupuestoDao CrearPresupuestoDao()
        {
            return new PresupuestoDao();
        }
    }
}
