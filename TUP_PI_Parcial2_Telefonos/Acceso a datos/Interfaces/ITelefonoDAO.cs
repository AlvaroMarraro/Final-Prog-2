using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Interfaces
{
    interface ITelefonoDAO
    {
        DataTable CargarComboTelefonos();
        DataTable CargarListaTelefonos();
        bool NuevoTelefono(Telefono oTelefono);
    }
}
