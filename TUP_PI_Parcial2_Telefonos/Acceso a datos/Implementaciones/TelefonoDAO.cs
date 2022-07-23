using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Interfaces;

namespace TUP_PI_Parcial2_Telefonos.Acceso_a_datos.Implementaciones
{
    class TelefonoDAO : ITelefonoDAO
    {
        public DataTable CargarComboTelefonos()
        {
            DataTable tabla = new DataTable();
            
            string query = "SELECT * FROM Marcas";

            tabla = HelperDAO.ObtenerInstancia().ConsultarSQL(query);
            

            return tabla;
        }

      

        public DataTable CargarListaTelefonos()
        {
            DataTable tabla = new DataTable();

            string query = "SELECT codigo as CODIGO, nombre as NOMBRE From Telefonos ORDER BY 1";

            tabla = HelperDAO.ObtenerInstancia().ConsultarSQL(query);

            return tabla;
        }

        

        public bool NuevoTelefono(Telefono oTelefono)
        {
            int filasAfectadas = 0;
            bool resultado = true;
            string query = "INSERT INTO Telefonos VALUES(@codigo, @nombre, @marca, @precio)";

            filasAfectadas = HelperDAO.ObtenerInstancia().EjecutarSqlNuevoTelefono(query, oTelefono);

            if (filasAfectadas == 0) resultado = false;

            return resultado;

        }
    }
}
