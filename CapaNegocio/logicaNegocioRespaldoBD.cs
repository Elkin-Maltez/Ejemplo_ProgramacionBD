using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    class logicaNegocioRespaldoBD
    {
        accesoDatosRespaldoBD rbd = new accesoDatosRespaldoBD();

        public int respaldarBD()
        {
            return rbd.respaldarBD();
        }
    }
}
