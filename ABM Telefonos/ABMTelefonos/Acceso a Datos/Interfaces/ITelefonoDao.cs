using ABMTelefonos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Acceso_a_Datos.Interfaces
{
    interface ITelefonoDao
    {
        DataTable CargarCombo();
        DataTable CargarListaTelefonos();
        bool GrabarTelefono(Entidades.Telefono oTelefono);
        Telefono TraerDatosTelefono(int pk);
        bool ActualizarTelefono(Telefono oTelefono);
        bool BorrarTelefono(Telefono oTelefono);
    }
}
