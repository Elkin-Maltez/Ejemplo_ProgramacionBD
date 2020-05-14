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
            //textBoxId.Visible = false;
            //labelIdSolicitud.Visible = false;
            dataGridViewSolicitud.DataSource = logicaNS.listarSolicitud();
        }
    }
}
