using ABMTelefonos.Acceso_a_Datos.Interfaces;
using ABMTelefonos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Acceso_a_Datos.Implementaciones
{
    class TelefonoDao : ITelefonoDao
    {
        public bool ActualizarTelefono(Telefono oTelefono)
        {
            int filasAfectadas = 0;
            bool resultado = true;

            int codigo = oTelefono.Codigo;

            string query = "UPDATE Telefonos SET nombre = @nombre, marca = @marca, precio = @precio WHERE codigo = " + codigo;

            filasAfectadas = HelperDao.ObtenerInstancia().ActualizarTelefono(query, oTelefono);

            if (filasAfectadas == 0) 
            {
                resultado = false;
            }

            return resultado;
        }

       

        public bool BorrarTelefono(Telefono oTelefono)
        {
            int filasAfectadas = 0;
            bool resultado = true;

            int codigo = oTelefono.Codigo;

            string query = "DELETE from Telefonos WHERE codigo =" + codigo;

            filasAfectadas = HelperDao.ObtenerInstancia().BorrarTelefono(query, oTelefono);

            if (filasAfectadas == 0) resultado = false;

            return resultado;
        }

        public DataTable CargarCombo()
        {
            DataTable tabla = new DataTable();

            string query = "SELECT * FROM Marcas";

            tabla = HelperDao.ObtenerInstancia().ConsultaSQL(query);

            return tabla;
        }

        public DataTable CargarListaTelefonos()
        {
            DataTable tabla = new DataTable();

            string query = "Select CONVERT(varchar, T.codigo) + ' - ' + T.nombre as 'Lista'  FROM Telefonos T ORDER BY 1";

            tabla = HelperDao.ObtenerInstancia().ConsultaSQL(query);

            return tabla;
        }

        

        public bool GrabarTelefono(Telefono oTelefono)
        {
            int filasAfectadas = 0;
            bool resultado = true;

            string query = "INSERT INTO Telefonos values (@codigo, @nombre, @marca, @precio)";

            filasAfectadas = HelperDao.ObtenerInstancia().GrabarNuevoTelefono(query, oTelefono);

            if (filasAfectadas == 0) resultado = false;

            return resultado;
        }

        public Telefono TraerDatosTelefono(int pk)
        {
            Telefono oTelefono = new Telefono();
            DataTable table = new DataTable();

            string query = "SELECT * FROM Telefonos WHERE codigo =" + pk;

            table = HelperDao.ObtenerInstancia().ConsultaSQL(query);

            bool primerRegistro = true;

            DataTableReader reader = table.CreateDataReader();

            while (reader.Read()) 
            {
                if (primerRegistro) 
                {
                    oTelefono.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                    oTelefono.Nombre = reader["nombre"].ToString();
                    oTelefono.Marca = Convert.ToInt32(reader["marca"].ToString());
                    oTelefono.Precio = Convert.ToDouble(reader["precio"].ToString());

                }

                primerRegistro = false;
                          

            }

            return oTelefono;
        }
    }
}
