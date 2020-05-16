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

namespace capaPresentacionWF
{
    public partial class fRecursos : Form
    {
        logicaNegocioRecurso logicaNR = new logicaNegocioRecurso();

        public fRecursos()
        {
            InitializeComponent();
        }
        
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                    Recurso objetoRecurso = new Recurso();
                    objetoRecurso.nombrer = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaNR.insertarRecurso(objetoRecurso) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewRecursos.DataSource = logicaNR.listarRecurso();
                        textBoxNombrer.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxCodigo.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Recurso");
                    }
                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    Recurso objetoRecurso = new Recurso();
                    objetoRecurso.idrecursos = Convert.ToInt32(textBoxId.Text);
                    objetoRecurso.nombrer = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaNR.editarRecurso(objetoRecurso) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewRecursos.DataSource = logicaNR.listarRecurso();
                        textBoxNombrer.Text = "";
                        textBoxDescripcion.Text = "";
                        textBoxCodigo.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Recurso");
                    }
                    buttonGuardar.Text = "GUARDAR";
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fRecursos_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewRecursos.DataSource = logicaNR.listarRecurso();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewRecursos.CurrentRow.Cells["idrecursos"].Value.ToString();
            textBoxNombrer.Text = dataGridViewRecursos.CurrentRow.Cells["nombrer"].Value.ToString();
            textBoxCodigo.Text = dataGridViewRecursos.CurrentRow.Cells["codigo"].Value.ToString();
            textBoxDescripcion.Text = dataGridViewRecursos.CurrentRow.Cells["descripcion"].Value.ToString();

            tabRecursos.SelectedTab = tabPage1;
            buttonGuardar.Text = "Actualizar";

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoR = Convert.ToInt32(dataGridViewRecursos.CurrentRow.Cells["idrecurso"].Value.ToString());

            try
            {
                if (logicaNR.eliminarRecurso(codigoR)>0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewRecursos.DataSource = logicaNR.listarRecurso();
                }
            }
            catch 
            {
                MessageBox.Show("ERROR al eliminar recurso");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Recurso> listaRecursos = logicaNR.BuscarRecurso(textBoxBuscar.Text);
            dataGridViewRecursos.DataSource = listaRecursos;
        }
    }
}