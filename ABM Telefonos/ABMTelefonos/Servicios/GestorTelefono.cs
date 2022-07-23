using ABMTelefonos.Acceso_a_Datos.Implementaciones;
using ABMTelefonos.Acceso_a_Datos.Interfaces;
using ABMTelefonos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Servicios
{
    class GestorTelefono
    {
        private ITelefonoDao dao;
        public GestorTelefono(AbstractDaoFactory factory) 
        {

            dao = factory.CrearTelefonoDao();
            
        }

        public DataTable CargarComboMarca()
        {
            return dao.CargarCombo();
        }

        public DataTable CargarListaTelefonos()
        {
            return dao.CargarListaTelefonos();
        }

        public bool GrabarTelefono(Telefono oTelefono)
        {
            return dao.GrabarTelefono(oTelefono);
        }

        public Telefono TraerTelefonoUnico(int pk)
        {
            return dao.TraerDatosTelefono(pk);
        }

        public bool ActualizarTelefono(Telefono oTelefono)
        {
            return dao.ActualizarTelefono(oTelefono);
        }

        public bool BorrarTelefono(Telefono oTelefono)
        {
            return dao.BorrarTelefono(oTelefono);
        }
    }
}
