using ABMTelefonos.Acceso_a_Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Acceso_a_Datos.Implementaciones
{
    abstract class AbstractDaoFactory
    {
        public abstract ITelefonoDao CrearTelefonoDao();
    }
}
