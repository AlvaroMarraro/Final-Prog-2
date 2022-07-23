using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Implementaciones;
using TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Interfaces;

namespace TUP_PI_Parcial2_Telefonos.Servicios
{
    class GestorTelefono
    {
        private ITelefonoDAO dao;
        public GestorTelefono(AbstractDAOFactory factory) 
        {
            dao = factory.CrearTelefonoDAO();
        
        }

        public DataTable CargarComboTelefonos()
        {
            return dao.CargarComboTelefonos();
        }

        public  DataTable CargarListaTelefonos()
        {
            return dao.CargarListaTelefonos(); 
        }

        public bool NuevoTelefono(Telefono oTelefono)
        {
            return dao.NuevoTelefono(oTelefono);
        }
    }
}
