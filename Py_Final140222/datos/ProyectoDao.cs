using Py_Final030222.Servicios;
using Py_Final140222.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final030222.datos
{
    class ProyectoDao : IProyectoDao
    {
        public List<Proyecto> ConsultarPresupuestos()
        {
            List<Proyecto> lst = new List<Proyecto>();
            DataTable table = new DataTable();

            try
            {
                table = HelperDao.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_PROYECTOS");

                foreach (DataRow row in table.Rows)
                {
                    Proyecto oProyecto = new Proyecto();
                    oProyecto.ProyectoId = Convert.ToInt32(row["id_proyecto"].ToString());
                    oProyecto.Nombre = row["nombre"].ToString();
                    oProyecto.fechaInicio = Convert.ToDateTime(row["fecha_inicio"].ToString());

                    if (!row["fecha_fin"].Equals(DBNull.Value))
                    {
                        oProyecto.fechaFin = Convert.ToDateTime(row["fecha_fin"].ToString());
                    }
                        

                    lst.Add(oProyecto);
                }

            }
            catch (SqlException)
            {

                lst = null;
            }
            return lst;
        }

        public List<Proyecto> ConsultarProyectosFiltros(List<Parametro> filtros)
        {
            List<Proyecto> lst = new List<Proyecto>();
            DataTable tabla = new DataTable();

            try
            {
                tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametrosEntrada("SP_CONSULTAR_PROYECTOS_POR_FECHA", filtros);

                foreach (DataRow row in tabla.Rows)
                {
                    Proyecto oProyecto = new Proyecto();
                    oProyecto.ProyectoId = Convert.ToInt32(row["id_proyecto"].ToString());
                    oProyecto.Nombre = row["nombre"].ToString();
                    oProyecto.fechaInicio = Convert.ToDateTime(row["fecha_inicio"].ToString());

                    if (!row["fecha_fin"].Equals(DBNull.Value))
                    {
                        oProyecto.fechaFin = Convert.ToDateTime(row["fecha_fin"].ToString());
                    }


                    lst.Add(oProyecto);
                }
            }
            catch (Exception)
            {

                lst = null;
            }

            return lst;
        }

        public Proyecto ConsultarUnProyecto(int nroProyecto)
        {
            Proyecto oProyecto = new Proyecto();
            DataTable tabla = new DataTable();
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id_proyecto", nroProyecto));

            tabla = HelperDao.ObtenerInstancia().ConsultaSQLParametrosEntrada("SP_CONSULTAR_PROYECTOS_POR_ID", parametros);

            bool primerRegistro = true;

            DataTableReader lector = tabla.CreateDataReader();

            while (lector.Read()) 
            {
                if (primerRegistro) 
                {
                    oProyecto.ProyectoId = Convert.ToInt32(lector["id_proyecto"].ToString());
                    oProyecto.Nombre = lector["nombre"].ToString();
                    oProyecto.fechaInicio = Convert.ToDateTime(lector["fecha_inicio"].ToString());

                    if (!lector["fecha_fin"].Equals(DBNull.Value))
                    {
                        oProyecto.fechaFin = Convert.ToDateTime(lector["fecha_fin"].ToString());
                    }

                    primerRegistro = false;
                }

                Empleado oEmpleado = new Empleado();
                DetalleRecurso oDetalle = new DetalleRecurso();
                oEmpleado.EmpleadoId = Convert.ToInt32(lector["id_empleado"].ToString());
                oEmpleado.Nombre = lector["nombre"].ToString();
                oEmpleado.Apellido = lector["apellido"].ToString();
                oEmpleado.DNI = Convert.ToInt32(lector["dni"].ToString());

                oDetalle.Empleado = oEmpleado;
                oDetalle.Rol = lector["rol"].ToString();
                oDetalle.HrsSemana = Convert.ToInt32(lector["hrsSemana"].ToString());

                oProyecto.AgregarDetalle(oDetalle);
      
            }


            return oProyecto;
        }

        public bool FinalizarProyecto(int nroPresupuesto)
        {
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@id_proyecto", nroPresupuesto));

            bool resultado = true;
            int filasAfectadas = 0;

            filasAfectadas = HelperDao.ObtenerInstancia().EjecutarSQLParametrosEntrada("SP_FINALIZAR_PROYECTOS_POR_ID", parametros);

            if (filasAfectadas == 0) resultado = false;

            return resultado;
                
        }
    }
}
