namespace capaPresentacionWF4
{
    partial class fCuenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCuenta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelIdCuenta = new System.Windows.Forms.Label();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCuenta = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabCuenta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCuenta
            // 
            this.tabCuenta.Controls.Add(this.tabPage1);
            this.tabCuenta.Controls.Add(this.tabPage2);
            this.tabCuenta.Location = new System.Drawing.Point(-1, -1);
            this.tabCuenta.Name = "tabCuenta";
            this.tabCuenta.SelectedIndex = 0;
            this.tabCuenta.Size = new System.Drawing.Size(801, 452);
            this.tabCuenta.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxClave);
            this.tabPage1.Controls.Add(this.textBoxNombreUsuario);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelClave);
            this.tabPage1.Controls.Add(this.labelNombreUsuario);
            this.tabPage1.Controls.Add(this.labelIdCuenta);
            this.tabPage1.Controls.Add(this.labelCuenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.Location = new System.Drawing.Point(284, 312);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(206, 43);
            this.buttonGuardar.TabIndex = 48;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(362, 222);
            this.textBoxClave.Multiline = true;
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(233, 26);
            this.textBoxClave.TabIndex = 47;
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(362, 161);
            this.textBoxNombreUsuario.Multiline = true;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(233, 26);
            this.textBoxNombreUsuario.TabIndex = 46;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(362, 101);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(233, 26);
            this.textBoxId.TabIndex = 45;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelClave.Location = new System.Drawing.Point(167, 224);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(60, 24);
            this.labelClave.TabIndex = 44;
            this.labelClave.Text = "Clave";
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(167, 163);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(163, 24);
            this.labelNombreUsuario.TabIndex = 43;
            this.labelNombreUsuario.Text = "Nombre Usuario";
            this.labelNombreUsuario.UseWaitCursor = true;
            // 
            // labelIdCuenta
            // 
            this.labelIdCuenta.AutoSize = true;
            this.labelIdCuenta.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIdCuenta.Location = new System.Drawing.Point(167, 103);
            this.labelIdCuenta.Name = "labelIdCuenta";
            this.labelIdCuenta.Size = new System.Drawing.Size(36, 24);
            this.labelIdCuenta.TabIndex = 42;
            this.labelIdCuenta.Text = "ID";
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCuenta.Location = new System.Drawing.Point(217, 3);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(299, 59);
            this.labelCuenta.TabIndex = 41;
            this.labelCuenta.Text = "Registrar Cuenta";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewCuenta);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(315, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 59);
            this.label2.TabIndex = 27;
            this.label2.Text = "Información";
            // 
            // dataGridViewCuenta
            // 
            this.dataGridViewCuenta.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuenta.Location = new System.Drawing.Point(54, 221);
            this.dataGridViewCuenta.Name = "dataGridViewCuenta";
            this.dataGridViewCuenta.Size = new System.Drawing.Size(670, 194);
            this.dataGridViewCuenta.TabIndex = 26;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminar.Location = new System.Drawing.Point(558, 143);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(140, 31);
            this.buttonEliminar.TabIndex = 25;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditar.Location = new System.Drawing.Point(656, 104);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(110, 28);
            this.buttonEditar.TabIndex = 24;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Location = new System.Drawing.Point(494, 106);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(112, 27);
            this.buttonBuscar.TabIndex = 23;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(129, 106);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(329, 26);
            this.textBoxBuscar.TabIndex = 22;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBuscar.Location = new System.Drawing.Point(30, 109);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 24);
            this.labelBuscar.TabIndex = 21;
            this.labelBuscar.Text = "Buscar";
            // 
            // fCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabCuenta);
            this.Name = "fCuenta";
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.fCuenta_Load);
            this.tabCuenta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCuenta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCuenta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxNombreUsuario;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelIdCuenta;
        private System.Windows.Forms.Label labelCuenta;
    }
}

