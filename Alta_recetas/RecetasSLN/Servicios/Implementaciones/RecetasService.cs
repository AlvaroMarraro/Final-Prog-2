using RecetasSLN.datos;
using RecetasSLN.dominio;
using RecetasSLN.Servicios.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.Servicios
{
    class RecetasService : IService 
    {
        private IRecetaDao dao;

        public RecetasService()
        {
            dao = new RecetaDao();
        }

        public List<Ingredientes> ConsultarProducto()
        {
            return dao.ConsultarProductos();
        }

        public List<Recetas> ConsultarRecetas(List<Parametro> filtros)
        {
           return dao.ConsultarRecetas(filtros);
        }

        public bool GrabarReceta(Recetas oReceta)
        {
            return dao.SaveReceta(oReceta);
        }

        public int ObtenerProximaRecetaID()
        {
           return dao.ProximaRecetaId();
        }

        public bool RegistrarBajaReceta(int receta)
        {
            return dao.RegistrarBaja(receta);
        }
    }
}

