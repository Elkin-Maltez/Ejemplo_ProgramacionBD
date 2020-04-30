using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioSolicitud
    {
        accesoDatosSolicitud ads = new accesoDatosSolicitud();

        public int insertarSolicitud(Solicitud so)
        {
            return ads.insertarSolcitud(so);
        }
        public List<Solicitud> listarSolicitud()
        {
            return ads.listarSolicitud();
        }
        public int eliminarSolicitud(int idsolicit)
        {
            return ads.eliminarSolicitud(idsolicit);
        }
        public int editarSolicitud(Solicitud so)
        {
            return ads.EditarSolicitud(so);
        }
        public List<Solicitud> BuscarSolicitud(string dato)
        {
            return ads.BuscarSolicitud(dato);
        }
    }
}
