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

namespace capaPresentacionWF4
{
    public partial class fCuenta : Form
    {
        logicaNegocioCuenta logicaNCt = new logicaNegocioCuenta();

        public fCuenta()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "GUARDAR")
                {
                   Cuenta objetoCuenta = new Cuenta();
                    objetoCuenta.nombreuser = textBoxNombreUsuario.Text;
                    objetoCuenta.clave = textBoxClave.Text;
                    objetoCuenta.idusuario = Convert.ToInt32(textBoxIdUsuario.Text);

                    if (logicaNCt.insertarCuentas(objetoCuenta) > 0)
                    {
                        MessageBox.Show("Agregado con éxito");
                        dataGridViewCuenta.DataSource = logicaNCt.listarCuentas();
                        textBoxNombreUsuario.Text = "";
                        textBoxClave.Text = "";
                        textBoxIdUsuario.Text = "";

                        tabCuenta.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Cuenta");
                    }
                }
                if (buttonGuardar.Text == "ACTUALIZAR")
                {
                    Cuenta objetoCuenta = new Cuenta();
                    objetoCuenta.idcuenta = Convert.ToInt32(textBoxId.Text);
                    objetoCuenta.nombreuser = textBoxNombreUsuario.Text;
                    objetoCuenta.clave = textBoxClave.Text;

                    if (logicaNCt.editarCuentas(objetoCuenta) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewCuenta.DataSource = logicaNCt.listarCuentas();
                        textBoxNombreUsuario.Text = "";
                        textBoxClave.Text = "";
                        textBoxIdUsuario.Text = "";

                        tabCuenta.SelectedTab = tabPage2;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Cuenta");
                    }
                    buttonGuardar.Text = "GUARDAR";
                }
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }
        }

        private void fCuenta_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelIdCuenta.Visible = false;
            dataGridViewCuenta.DataSource = logicaNCt.listarCuentas();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelIdCuenta.Visible = true;

            textBoxId.Text = dataGridViewCuenta.CurrentRow.Cells["idcuenta"].Value.ToString();
            textBoxNombreUsuario.Text = dataGridViewCuenta.CurrentRow.Cells["nombreuser"].Value.ToString();
            textBoxClave.Text = dataGridViewCuenta.CurrentRow.Cells["clave"].Value.ToString();
           
            tabCuenta.SelectedTab = tabPage1;
            buttonGuardar.Text = "ACTUALIZAR";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigoCt = Convert.ToInt32(dataGridViewCuenta.CurrentRow.Cells["idcuenta"].Value.ToString());

            try
            {
                if (logicaNCt.eliminarCuentas(codigoCt) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewCuenta.DataSource = logicaNCt.listarCuentas();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar cuenta");
            }
        }
        
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Cuenta> listaCuenta = logicaNCt.BuscarCuentas(textBoxBuscar.Text);
            dataGridViewCuenta.DataSource = listaCuenta;
        }
    }
}
