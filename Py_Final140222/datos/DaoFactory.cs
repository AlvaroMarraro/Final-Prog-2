using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Py_Final030222.datos
{
    class DaoFactory : AbstractDaoFactory
    {
        public override IProyectoDao CrearProyectoDao()
        {
            return new ProyectoDao();
        }
    }
}
