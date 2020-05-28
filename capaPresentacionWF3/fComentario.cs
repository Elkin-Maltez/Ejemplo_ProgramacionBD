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
            textBoxId.Visible = false;
            labelIdComentario.Visible = false;
            dataGridViewComentario.DataSource = logicaNC.listarComentario();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelIdComentario.Visible = true;

            textBoxId.Text = dataGridViewComentario.CurrentRow.Cells["idcomentario"].Value.ToString();
            textBoxNombre.Text = dataGridViewComentario.CurrentRow.Cells["nombres"].Value.ToString();
            textBoxCorreo.Text = dataGridViewComentario.CurrentRow.Cells["correo"].Value.ToString();
            textBoxTelefono.Text = dataGridViewComentario.CurrentRow.Cells["telefono"].Value.ToString();
            textBoxMensaje.Text = dataGridViewComentario.CurrentRow.Cells["mensaje"].Value.ToString();

            tabComentario.SelectedTab = tabPage1;
            buttonGuardar.Text = "ACTUALIZAR";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoC = Convert.ToInt32(dataGridViewComentario.CurrentRow.Cells["idcomentario"].Value.ToString());

            try
            {
                if (logicaNC.eliminarComentarios(codigoC) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewComentario.DataSource = logicaNC.listarComentario();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar comentario");
            }
        }
        
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Comentario> listaComentario = logicaNC.BuscarComentarios(textBoxBuscar.Text);
            dataGridViewComentario.DataSource = listaComentario;
        }
    }
}