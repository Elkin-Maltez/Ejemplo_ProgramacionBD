using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioComentario
    {
        accesoDatosComentario ac = new accesoDatosComentario();

        public int insertarComentarios(Comentario co)
        {
            return ac.insertarComentarios(co);
        }
        public List<Comentario> listarComentario()
        {
            return ac.listarComentarios();
        }
        public int eliminarComentarios(int idcoment)
        {
            return ac.eliminarComentario(idcoment);
        }
        public int editarComentarios(Comentario co)
        {
            return ac.EditarComentarios(co);
        }
        public List<Comentario> BuscarComentarios(string dato)
        {
            return ac.BuscarComentarios(dato);
        }
    }
}
