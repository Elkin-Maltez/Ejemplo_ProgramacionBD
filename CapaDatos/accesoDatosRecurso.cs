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
    public class accesoDatosRecurso
    {
        SqlConnection cnx;
        Recurso r = new Recurso();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Recurso> listaRecurso= null;

        public int insertarRecurso(Recurso re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurs", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", re.nombrer);
                cm.Parameters.AddWithValue("@codigo", re.codigo);
                cm.Parameters.AddWithValue("@descripcion", re.descripcion);
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

        public List<Recurso> listarRecurso()
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurs", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecurso = new List<Recurso>();

                while (dr.Read())
                {
                    Recurso r = new Recurso();
                    r.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    r.nombrer = dr["nombrer"].ToString();
                    r.codigo = dr["codigo"].ToString();
                    r.descripcion = dr["descripcion"].ToString();
                    listaRecurso.Add(r);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecurso = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaRecurso;
        }

        public int eliminarRecurso(int idrecurs)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurs", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idrecursos", idrecurs);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

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

        public int EditarRecurso(Recurso re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurs", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idrecursos", re.idrecursos);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", re.descripcion);

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

        public List<Recurso> BuscarRecurso(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("Recurs", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", dato);
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecurso = new List<Recurso>();

                while (dr.Read())
                {
                    Recurso r = new Recurso();
                    r.idrecursos = Convert.ToInt32(dr["idrecursos"].ToString());
                    r.nombrer = dr["nombrer"].ToString();
                    r.codigo = dr["codigo"].ToString();
                    r.descripcion = dr["descripcion"].ToString();
                    listaRecurso.Add(r);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecurso = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaRecurso;
        }
    }
}