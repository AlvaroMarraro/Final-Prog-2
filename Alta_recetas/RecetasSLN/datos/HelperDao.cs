using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class HelperDao
    {
        private static HelperDao instancia;
        private string connectionString;
        SqlConnection cnn;
        SqlCommand cmd;
        private HelperDao()
        {
            connectionString = Properties.Resources.strConexion;
            cnn = new SqlConnection(connectionString);
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
        public DataTable ConsultaSQL(string storeName)
        {
           
            DataTable tabla = new DataTable();
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public int ProximoID(string nombreSP, string paramSP)
        {
          
            SqlParameter param = new SqlParameter(paramSP, SqlDbType.Int);

            try
            {
                cmd.Parameters.Clear();
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                return Convert.ToInt32(param.Value);
            }

            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }

        public void InsertarMaestroDetalleSQL(string SpMaestro, string SpDetalle, Recetas oReceta)
        {
            int filasAfectadas = 0;
            SqlTransaction t = null;
            try
            {
                cmd.Parameters.Clear();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SpMaestro;

                
                cmd.Parameters.AddWithValue("@tipo_receta", oReceta.TipoReceta);
                cmd.Parameters.AddWithValue("@nombre", oReceta.Nombre);
                cmd.Parameters.AddWithValue("@cheff", oReceta.Cheff);
                cmd.Parameters.AddWithValue("@fecha", oReceta.Fecha);

                SqlParameter param = new SqlParameter("@id_receta", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();

                oReceta.RecetaNro = Convert.ToInt32(param.Value);

                //hasta aca cmdMAestro

                int detalleNro = 1;
                foreach (DetalleRecetas item in oReceta.Detalles)
                {
                    SqlCommand cmdDet = new SqlCommand();
                    cmdDet.Connection = cnn;
                    cmdDet.Transaction = t;
                    cmdDet.CommandType = CommandType.StoredProcedure;
                    cmdDet.CommandText = SpDetalle;

                    cmdDet.Parameters.AddWithValue("@RecetaNro", oReceta.RecetaNro);
                    cmdDet.Parameters.AddWithValue("@id_ingrediente", item.Ingredientes.IngredientesId);
                    cmdDet.Parameters.AddWithValue("@cantidad", item.Cantidad);



                }

            }
            catch (Exception ex)
            {
                filasAfectadas = 0;
                throw ex;
            }
            finally 
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
      
    }
}
