using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosCuenta
    {
        SqlConnection cnx;
        Cuenta c = new Cuenta();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cuenta> listaCuenta = null;

        public int insertarCuenta(Cuenta ct)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuent", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", ct.nombreuser);
                cm.Parameters.AddWithValue("@clave", ct.clave);
                
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Cuenta> listarCuenta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuent", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuenta = new List<Cuenta>();

                while (dr.Read())
                {
                    Cuenta c = new Cuenta();
                    c.idcuenta = Convert.ToInt32(dr["idcuenta"].ToString());
                    c.nombreuser = dr["nombreuser"].ToString();
                    c.clave = dr["clave"].ToString();
                    listaCuenta.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuenta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCuenta;
        }

        public int eliminarCuenta(int idcuent)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuent", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcuenta", idcuent);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public int EditarCuenta(Cuenta cu)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuent", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcuenta", cu.idcuenta);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", cu.clave);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public List<Cuenta> BuscarCuenta(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Cuent", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", dato);
                cm.Parameters.AddWithValue("@clave", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCuenta = new List<Cuenta>();
                while (dr.Read())
                {
                    Cuenta c = new Cuenta();
                    c.idcuenta = Convert.ToInt32(dr["idcuenta"].ToString());
                    c.nombreuser = dr["nombreuser"].ToString();
                    c.clave = dr["clave"].ToString();
                    listaCuenta.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCuenta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCuenta;
        }
    }
}