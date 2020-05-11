using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosComentario
    {
        SqlConnection cnx;
        Comentario s = new Comentario();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Comentario> listaComentario = null;

        public int insertarComentarios(Comentario co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", co.nombres);
                cm.Parameters.AddWithValue("@correo", co.correo);
                cm.Parameters.AddWithValue("@telefono", co.telefono);
                cm.Parameters.AddWithValue("@mensaje", co.mensaje);

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

        public List<Comentario> listarComentarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaComentario = new List<Comentario>();

                while (dr.Read())
                {
                    Comentario c = new Comentario();
                    c.idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.nombres = dr["nombres"].ToString();
                    c.correo = dr["correo"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    c.mensaje = dr["mensaje"].ToString();
                    listaComentario.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaComentario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaComentario;
        }
        public int eliminarComentario(int idcoment)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcomentario", idcoment);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

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

        public int EditarComentarios(Comentario co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcomentario", co.idcomentario);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", co.mensaje);

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

        public List<Comentario> BuscarComentarios(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaComentario = new List<Comentario>();
                while (dr.Read())
                {
                    Comentario c = new Comentario();
                    c.idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.nombres = dr["nombre"].ToString();
                    c.correo = dr["correo"].ToString();
                    c.telefono = dr["telefono"].ToString();
                    c.mensaje = dr["mensaje"].ToString();
                    listaComentario.Add(c);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaComentario = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaComentario;
        }
    }
}