using RecetasSLN.Servicios;
using RecetasSLN.Servicios.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    class ServiceFactoryImp : AbstractServiceFactory
    {
        public override IService CrearService()
        {
            return new RecetasService();
        }
    }
}
