using ABMTelefonos.Acceso_a_Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Acceso_a_Datos.Implementaciones
{
    class DaoFactory : AbstractDaoFactory
    {
        public override ITelefonoDao CrearTelefonoDao()
        {
            return new TelefonoDao();
        }
    }
}
