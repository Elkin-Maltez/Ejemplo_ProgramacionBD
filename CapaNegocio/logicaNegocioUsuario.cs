using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioUsuario
    {
        accesoDatosUsuario adu = new accesoDatosUsuario();

        public int insertarUsuarios(Usuario us)
        {
            return adu.insertarUsuario(us);
        }
        public List<Usuario> listarUsuario()
        {
            return adu.listarUsuario();
        }
        public int eliminarUsuario(int idusuar)
        {
            return adu.eliminarUsuario(idusuar);
        }
        public int editarUsuario(Usuario us)
        {
            return adu.EditarUsuario(us);
        }
        public List<Usuario> BuscarUsuario(string dato)
        {
            return adu.BuscarUsuario(dato);
        }
    }
}
