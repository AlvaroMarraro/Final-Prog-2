﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Interfaces;

namespace TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Implementaciones
{
    class DAOFactory : AbstractDAOFactory
    {
        public override ITelefonoDAO CrearTelefonoDAO() 
        {
            return new TelefonoDAO();
        
        }
    }
}
