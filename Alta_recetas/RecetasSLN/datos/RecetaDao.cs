using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class RecetaDao : IRecetaDao
    {
        public List<Ingredientes> ConsultarProductos()
        {
            

                List<Ingredientes> lst = new List<Ingredientes>();
                SqlConnection cnn = new SqlConnection(@"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog = db_recetas; Integrated Security = True");
                cnn.Open();
                SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_INGREDIENTES", cnn);

                cmd2.CommandType = CommandType.StoredProcedure;

                DataTable table = new DataTable();
                table.Load(cmd2.ExecuteReader());

                cnn.Close();

                foreach (DataRow row in table.Rows)
                {
                    Ingredientes oIngredientes = new Ingredientes();
                    oIngredientes.IngredientesId = Convert.ToInt32(row["id_ingrediente"].ToString());
                    oIngredientes.Nombre = row["n_ingrediente"].ToString();
                    oIngredientes.Unidad = row["unidad_medida"].ToString();


                    lst.Add(oIngredientes);
                }
                return lst;
            
        }

        public List<Recetas> ConsultarRecetas(List<Parametro> filtros)
        {
            List<Recetas> lst = new List<Recetas>();
            SqlConnection cnn = new SqlConnection(@"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog = db_recetas; Integrated Security = True");
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_RECETAS", cnn);

            cmd2.CommandType = CommandType.StoredProcedure;

            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());

            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                Recetas oRecetas = new Recetas();
                oRecetas.RecetaNro = Convert.ToInt32(row["id_receta"].ToString());
                oRecetas.Nombre = row["nombre"].ToString();
                oRecetas.Cheff = row["cheff"].ToString();
                oRecetas.TipoReceta = Convert.ToInt32(row["activo"].ToString());

                lst.Add(oRecetas);
            }

            return lst;
        }

        public int ProximaRecetaId()
        {
            try
            {

                return HelperDao.ObtenerInstancia().ProximoID("SP_PROXIMO_ID", "@next");

            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }

        public bool RegistrarBaja(int receta)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog = db_recetas; Integrated Security = True");
            SqlTransaction t = null;
            int affected = 0;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SP_REGISTRAR_BAJA_RECETAS", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@presupuesto_nro", receta);
                affected = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (SqlException)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return affected == 1;
        }

        public bool SaveReceta(Recetas oReceta)
        {
            
            bool resultado = true;
            int filasAfectadas = 0;

            string spMaestro = "SP_INSERTAR_RECETA";
            string spDetalle = "SP_INSERTAR_DETALLES";

            filasAfectadas = HelperDao.ObtenerInstancia().InsertarMaestroDetalleSQL(spMaestro, spDetalle, oReceta);

            if (filasAfectadas == 0) resultado = false;
            return resultado;
        }


    }

        


        
}
