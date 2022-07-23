using PractiaFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiaFinal.AccesoDatos
{
    interface IPresupuestoDao
    {
        Presupuesto ConsultarUnPresupuesto(int nroPresupuesto);
        List<Producto> ConsultarProductos();
        string ObtenerProximoNumero();
    }
}
