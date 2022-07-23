using RecetasSLN.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios.Service
{
    interface IService
    {
        List<Ingredientes> ConsultarProducto();
        int ObtenerProximaRecetaID();
        bool GrabarReceta(Recetas oReceta);
        List<Recetas> ConsultarRecetas(List<Parametro> filtros);
        bool RegistrarBajaReceta(int receta);
    }
}
