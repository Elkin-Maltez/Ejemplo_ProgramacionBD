using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace capaPresentacionWF3
{
    public partial class fComentario : System.Windows.Forms.Form
    {
        logicaNegocioComentario logicaNC = new logicaNegocioComentario();

        public fComentario()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                     Comentario objetoComentario = new Comentario();
                    objetoComentario.nombres = textBoxNombre.Text;
                    objetoComentario.correo = textBoxCorreo.Text;
                    objetoComentario.telefono = textBoxTelefono.Text;
                    objetoComentario.mensaje = textBoxMensaje.Text;

                    if (logicaNC.insertarComentarios(objetoComentario) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewComentario.DataSource = logicaNC.listarComentario();
                        textBoxNombre.Text = "";
                        textBoxCorreo.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxMensaje.Text = "";
                        tabComentario.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Comentario");
                    }
                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    Comentario objetoComentario = new Comentario();
                    objetoComentario.idcomentario = Convert.ToInt32(textBoxId.Text);
                    objetoComentario.nombres = textBoxNombre.Text;
                    objetoComentario.correo = textBoxCorreo.Text;
                    objetoComentario.telefono = textBoxTelefono.Text;
                    objetoComentario.mensaje = textBoxMensaje.Text;

                    if (logicaNC.editarComentarios(objetoComentario) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewComentario.DataSource = logicaNC.listarComentario();
                        textBoxNombre.Text = "";
                        textBoxCorreo.Text = "";
                        textBoxTelefono.Text = "";
                        textBoxMensaje.Text = "";
                        tabComentario.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Comentario");
                    }
                    buttonGuardar.Text = "GUARDAR";
                }
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fComentario_Load(object sender, EventArgs e)
        {
            //textBoxId.Visible = false;
            //labelIdCuenta.Visible = false;
            dataGridViewComentario.DataSource = logicaNC.listarComentario();
        }
    }
}
