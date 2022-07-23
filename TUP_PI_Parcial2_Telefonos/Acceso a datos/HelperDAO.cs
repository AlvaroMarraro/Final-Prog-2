using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Parcial2_Telefonos.Acceso_a_datos
{
    class HelperDAO
    {
        private static HelperDAO instancia;
        private string cadenaConexion;
        SqlConnection cnn;
        SqlCommand cmd;

        public HelperDAO() 
        {
            cadenaConexion = Properties.Resources.strConexion;
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();

        }

        public static HelperDAO ObtenerInstancia() 
        {
            if (instancia == null) 
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public DataTable ConsultarSQL(string query) 
        {
            DataTable tabla = new DataTable();
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                tabla.Load(cmd.ExecuteReader());


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (cnn.State == ConnectionState.Open) 
                {
                    cnn.Close();
                }
            }
            



            return tabla;
        }

        public int EjecutarSqlNuevoTelefono(string query, Telefono oTelefono) 
        {
            int filasAfectadas = 0;
           

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                
                cmd.Parameters.AddWithValue("@codigo", oTelefono.pCodigo);
                cmd.Parameters.AddWithValue("@nombre", oTelefono.pNombre);
                cmd.Parameters.AddWithValue("@marca", oTelefono.pMarca);
                cmd.Parameters.AddWithValue("@precio", oTelefono.pPrecio);

                filasAfectadas = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
                filasAfectadas = 0;
            }
            finally 
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }


            return filasAfectadas;
        }



    }
}
