using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final030222.datos
{
    abstract class AbstractDaoFactory
    {
        public abstract IProyectoDao CrearProyectoDao();     

    }
}
