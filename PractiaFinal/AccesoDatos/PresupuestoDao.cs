using PractiaFinal.Entidades;
using PractiaFinal.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFinal.AccesoDatos
{
    class PresupuestoDao : IPresupuestoDao
    {
        public List<Producto> ConsultarProductos()
        {
            List<Producto> lst = new List<Producto>();
            DataTable tabla = HelperDao.ObtenerInstancia().ConsultarSql("SP_CONSULTAR_PRODUCTOS");
            foreach (DataRow row in tabla.Rows)
            {
                Producto oProducto = new Producto();
                oProducto.IdProducto = Convert.ToInt32(row["id_producto"].ToString());
                oProducto.NProducto = row["n_producto"].ToString();
                oProducto.Precio = Convert.ToDouble(row["precio"].ToString());
                oProducto.Activo = row["activo"].ToString().Equals("S");

                lst.Add(oProducto);
            }

            return lst;
        }

        public Presupuesto ConsultarUnPresupuesto(int nroPresupuesto)
        {
            Presupuesto oPresupesto = new Presupuesto();
            DataTable tabla = new DataTable();
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@nro", nroPresupuesto));

            tabla = HelperDao.ObtenerInstancia().ConsultarParametrosEntrada("SP_CONSULTAR_PRESUPUESTO_POR_ID", parametros);

            bool primerRegistro = true;

            DataTableReader lector = tabla.CreateDataReader();

            while (lector.Read())
            {
                if (primerRegistro) 
                {
                    oPresupesto.PresupuestoNro = Convert.ToInt32(lector["presupuesto_nro"].ToString());
                    oPresupesto.Cliente = lector["cliente"].ToString();
                    oPresupesto.Fecha = Convert.ToDateTime(lector["fecha"].ToString());
                    oPresupesto.Descuento = Convert.ToDouble(lector["descuetno"].ToString());
                    oPresupesto.PresupuestoNro = Convert.ToInt32(lector["presupuesto_nro"].ToString());
                    oPresupesto.Total = Convert.ToDouble(lector["total"].ToString());
                    if (!lector.IsDBNull(4)) 
                    {
                        oPresupesto.FechaBaja = Convert.ToDateTime(lector["fecha_baja"].ToString());
                    }
                    else 
                    {
                        oPresupesto.FechaBaja = DateTime.MinValue;
                    
                    }

                    primerRegistro = false;
                }

                Producto oProducto = new Producto();
                DetallePresupuesto oDetalle = new DetallePresupuesto();
                oProducto.IdProducto = Convert.ToInt32(lector["presupuesto_nro"].ToString());
                oProducto.NProducto = lector["n_producto"].ToString();
                oProducto.Precio = Convert.ToDouble(lector["precio"].ToString());
                oProducto.Activo = lector["activo"].ToString().Equals("S");

                oDetalle.Producto = oProducto;
                oDetalle.Cantidad = Convert.ToInt32(lector["cantidad"].ToString());

                oPresupesto.AgregarDetalle(oDetalle);

            }
            return oPresupesto;
        }

        public string ObtenerProximoNumero()
        {
            return HelperDao.ObtenerInstancia().ProximoID("SP_PROXIMO_ID", "@next");
        }
    }
}
