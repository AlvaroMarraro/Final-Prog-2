using RecetasSLN.dominio;
using RecetasSLN.Servicios;
using System.Collections.Generic;
using System.Data;

namespace RecetasSLN.datos
{
    internal interface IRecetaDao
    {
       
        List<Ingredientes> ConsultarProductos();
        int ProximaRecetaId();
        bool SaveReceta(Recetas oReceta);
        List<Recetas> ConsultarRecetas(List<Parametro> filtros);
        bool RegistrarBaja(int receta);
    }
}