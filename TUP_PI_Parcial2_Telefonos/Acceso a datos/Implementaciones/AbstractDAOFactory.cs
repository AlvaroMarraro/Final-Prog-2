using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Interfaces;

namespace TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Implementaciones
{
    abstract class AbstractDAOFactory
    {
        public abstract ITelefonoDAO CrearTelefonoDAO();
    }
}
