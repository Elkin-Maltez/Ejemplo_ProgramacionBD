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
    public class accesoDatosUsuario
    {
        SqlConnection cnx;
        Usuario u = new Usuario();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Usuario> listaUsuario = null;

        public int insertarUsuario(Usuario us)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", us.cedula);
                cm.Parameters.AddWithValue("@nombres", us.nombres);
                cm.Parameters.AddWithValue("@apellidos", us.apellidos);
                cm.Parameters.AddWithValue("@email", us.email);
                cm.Parameters.AddWithValue("@telefono", us.telefono);

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

        public List<Usuario> listarUsuario()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaUsuario = new List<Usuario>();

                while (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    u.cedula = dr["cedula"].ToString();
                    u.nombres = dr["nombres"].ToString();
                    u.apellidos = dr["apellidos"].ToString();
                    u.email = dr["email"].ToString();
                    u.telefono = dr["telefono"].ToString();
                    listaUsuario.Add(u);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaUsuario;
        }

        public int eliminarUsuario(int idusuar)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idusuario", idusuar);
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

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

        public int EditarUsuario(Usuario us)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idusuario", us.idusuario);
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", us.telefono);

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

        public List<Usuario> BuscarUsuario(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Usuar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", dato);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaUsuario = new List<Usuario>();

                while (dr.Read())
                {
                    Usuario u = new Usuario();
                    u.idusuario = Convert.ToInt32(dr["idusuario"].ToString());
                    u.cedula = dr["cedula"].ToString();
                    u.nombres = dr["nombres"].ToString();
                    u.apellidos = dr["apellidos"].ToString();
                    u.email = dr["email"].ToString();
                    u.telefono = dr["telefono"].ToString();
                    listaUsuario.Add(u);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaUsuario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaUsuario;
        }
    }
}