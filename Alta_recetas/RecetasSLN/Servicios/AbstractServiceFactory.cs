using RecetasSLN.Servicios.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.datos
{
    abstract class AbstractServiceFactory
    {

        public abstract IService CrearService();

    }

}
