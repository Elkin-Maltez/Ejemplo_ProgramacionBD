using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class logicaNegocioCuenta
    {
        accesoDatosCuenta ad = new accesoDatosCuenta();

        public int insertarCuentas(Cuenta ct)
        {
            return ad.insertarCuenta(ct);
        }
        public List<Cuenta> listarCuentas()
        {
            return ad.listarCuenta();
        }
        public int eliminarCuentas(int idcuent)
        {
            return ad.eliminarCuenta(idcuent);
        }
        public int editarCuentas(Cuenta cu)
        {
            return ad.EditarCuenta(cu);
        }
        public List<Cuenta> BuscarCuentas(string dato)
        {
            return ad.BuscarCuenta(dato);
        }
    }
}
