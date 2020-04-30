using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioRecurso
    {
        accesoDatosRecurso ar = new accesoDatosRecurso();

        public int insertarRecurso(Recurso re)
        {
            return ar.insertarRecurso(re);
        }
        public List<Recurso> listarRecurso()
        {
            return ar.listarRecurso();
        }
        public int eliminarRecurso(int idrecurs)
        {
            return ar.eliminarRecurso(idrecurs);
        }
        public int editarRecurso(Recurso re)
        {
            return ar.EditarRecurso(re);
        }
        public List<Recurso> BuscarRecurso(string dato)
        {
            return ar.BuscarRecurso(dato);
        }
    }
}