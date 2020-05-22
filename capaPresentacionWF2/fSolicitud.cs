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

namespace capaPresentacionWF2
{
    public partial class fSolicitud : Form
    {
        logicaNegocioSolicitud logicaNS = new logicaNegocioSolicitud();

        public fSolicitud()
        {
            InitializeComponent();
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(textBoxFechaSolicitud.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(textBoxFechaUso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(textBoxHoraInicio.Text);
                    objetoSolicitud.horafinal = Convert.ToDateTime(textBoxHoraFinal.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;

                    if (logicaNS.insertarSolicitud(objetoSolicitud)> 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        textBoxFechaSolicitud.Text = "";
                        textBoxFechaUso.Text = "";
                        textBoxHoraInicio.Text = "";
                        textBoxHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Solicitud");
                    }
                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.idsolicitud = Convert.ToInt32(textBoxId.Text);
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(textBoxFechaSolicitud.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(textBoxFechaUso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(textBoxHoraInicio.Text);
                    objetoSolicitud.horafinal = Convert.ToDateTime(textBoxHoraFinal.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;

                    if (logicaNS.editarSolicitud(objetoSolicitud) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        textBoxFechaSolicitud.Text = "";
                        textBoxFechaUso.Text = "";
                        textBoxHoraInicio.Text = "";
                        textBoxHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Solicitud");
                    }
                    buttonGuardar.Text = "GUARDAR";
                }
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fSolicitud_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelIdSolicitud.Visible = false;
            dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelIdSolicitud.Visible = true;

            textBoxId.Text = dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString();
            textBoxAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            textBoxNivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            textBoxFechaSolicitud.Text = dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value.ToString();
            textBoxFechaUso.Text = dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value.ToString();
            textBoxHoraInicio.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            textBoxHoraFinal.Text = dataGridViewSolicitud.CurrentRow.Cells["horafinal"].Value.ToString();
            textBoxCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            textBoxAsignatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();

            tabSolicitud.SelectedTab = tabPage1;
            buttonGuardar.Text = "ACTUALIZAR";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoS = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString());

            try
            {
                if (logicaNS.eliminarSolicitud(codigoS) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar solicitud");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Solicitud> listaSolicitud = logicaNS.BuscarSolicitud(textBoxBuscar.Text);
            dataGridViewSolicitud.DataSource = listaSolicitud;
        }
    }
}
