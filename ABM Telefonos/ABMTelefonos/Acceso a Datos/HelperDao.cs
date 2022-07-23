using ABMTelefonos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMTelefonos.Acceso_a_Datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string cadenaConexion;
        SqlConnection cnn;
        SqlCommand cmd;

        private HelperDao() 
        {
            cadenaConexion = Properties.Resources.strConexion;
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
        
        }

        public static HelperDao ObtenerInstancia() 
        {
            if (instancia == null) 
            {
                instancia = new HelperDao();
            }

            return instancia;
        
        }

        public DataTable ConsultaSQL(string query) 
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
                tabla = null;
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

        public int BorrarTelefono(string query, Telefono oTelefono)
        {
            int filasAfectadas = 0;
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                filasAfectadas = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                filasAfectadas = 0;
                throw ex;
            }
            finally
            { 
                if(cnn.State == ConnectionState.Open) 
                {
                    cnn.Close();
                }
            }

            return filasAfectadas;
        }

        public int GrabarNuevoTelefono(string query, Telefono oTelefono) 
        {
            int filasAfectadas = 0;
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@codigo", oTelefono.Codigo);
                cmd.Parameters.AddWithValue("@nombre", oTelefono.Nombre);
                cmd.Parameters.AddWithValue("@marca", oTelefono.Marca);
                cmd.Parameters.AddWithValue("@precio", oTelefono.Precio);

                filasAfectadas = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
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

        public int ActualizarTelefono(string query, Telefono oTelefono) 
        {
            int filasAfectadas = 0;

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("nombre", oTelefono.Nombre);
                cmd.Parameters.AddWithValue("marca", oTelefono.Marca);
                cmd.Parameters.AddWithValue("precio", oTelefono.Precio);

                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                filasAfectadas = 0;
                throw ex;
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
