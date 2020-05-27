using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacionWF
{
    public partial class MDIRecursos : Form
    {
        private int childFormNumber = 0;
       
        public MDIRecursos()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        
        private void recursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["fRecursos"] != null)
            {
                Application.OpenForms["fRecursos"].Activate();
            }
            else
            {
                fRecursos fr = new fRecursos();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void salirtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
