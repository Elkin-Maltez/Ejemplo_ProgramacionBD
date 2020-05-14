namespace capaPresentacionWF3
{
    partial class fComentario
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
            this.tabComentario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelIdComentario = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewComentario = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabComentario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComentario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabComentario
            // 
            this.tabComentario.Controls.Add(this.tabPage1);
            this.tabComentario.Controls.Add(this.tabPage2);
            this.tabComentario.Location = new System.Drawing.Point(1, 1);
            this.tabComentario.Name = "tabComentario";
            this.tabComentario.SelectedIndex = 0;
            this.tabComentario.Size = new System.Drawing.Size(802, 450);
            this.tabComentario.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxMensaje);
            this.tabPage1.Controls.Add(this.textBoxTelefono);
            this.tabPage1.Controls.Add(this.textBoxCorreo);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelMensaje);
            this.tabPage1.Controls.Add(this.labelTelefono);
            this.tabPage1.Controls.Add(this.labelCorreo);
            this.tabPage1.Controls.Add(this.labelNombre);
            this.tabPage1.Controls.Add(this.labelIdComentario);
            this.tabPage1.Controls.Add(this.labelComentario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.Location = new System.Drawing.Point(304, 343);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(206, 43);
            this.buttonGuardar.TabIndex = 40;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Location = new System.Drawing.Point(351, 270);
            this.textBoxMensaje.Multiline = true;
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(233, 26);
            this.textBoxMensaje.TabIndex = 39;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(351, 228);
            this.textBoxTelefono.Multiline = true;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(233, 26);
            this.textBoxTelefono.TabIndex = 38;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(351, 185);
            this.textBoxCorreo.Multiline = true;
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(233, 26);
            this.textBoxCorreo.TabIndex = 37;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(351, 143);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(233, 26);
            this.textBoxNombre.TabIndex = 36;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(351, 101);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(233, 26);
            this.textBoxId.TabIndex = 35;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMensaje.Location = new System.Drawing.Point(188, 270);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(86, 24);
            this.labelMensaje.TabIndex = 34;
            this.labelMensaje.Text = "Mensaje";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTelefono.Location = new System.Drawing.Point(188, 228);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(90, 24);
            this.labelTelefono.TabIndex = 33;
            this.labelTelefono.Text = "Telefono";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCorreo.Location = new System.Drawing.Point(188, 185);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(69, 24);
            this.labelCorreo.TabIndex = 32;
            this.labelCorreo.Text = "Correo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombre.Location = new System.Drawing.Point(188, 143);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(82, 24);
            this.labelNombre.TabIndex = 31;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.UseWaitCursor = true;
            // 
            // labelIdComentario
            // 
            this.labelIdComentario.AutoSize = true;
            this.labelIdComentario.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdComentario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIdComentario.Location = new System.Drawing.Point(188, 101);
            this.labelIdComentario.Name = "labelIdComentario";
            this.labelIdComentario.Size = new System.Drawing.Size(36, 24);
            this.labelIdComentario.TabIndex = 30;
            this.labelIdComentario.Text = "ID";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelComentario.Location = new System.Drawing.Point(218, 3);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(357, 59);
            this.labelComentario.TabIndex = 11;
            this.labelComentario.Text = "Registrar Comentario";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewComentario);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(293, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 59);
            this.label2.TabIndex = 20;
            this.label2.Text = "Información";
            // 
            // dataGridViewComentario
            // 
            this.dataGridViewComentario.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewComentario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComentario.Location = new System.Drawing.Point(55, 212);
            this.dataGridViewComentario.Name = "dataGridViewComentario";
            this.dataGridViewComentario.Size = new System.Drawing.Size(670, 194);
            this.dataGridViewComentario.TabIndex = 19;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminar.Location = new System.Drawing.Point(557, 145);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(140, 31);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditar.Location = new System.Drawing.Point(655, 106);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(110, 28);
            this.buttonEditar.TabIndex = 17;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Location = new System.Drawing.Point(493, 108);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(112, 27);
            this.buttonBuscar.TabIndex = 16;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(128, 108);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(329, 26);
            this.textBoxBuscar.TabIndex = 15;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBuscar.Location = new System.Drawing.Point(29, 111);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 24);
            this.labelBuscar.TabIndex = 14;
            this.labelBuscar.Text = "Buscar";
            // 
            // fComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabComentario);
            this.Name = "fComentario";
            this.Text = "Comentario";
            this.Load += new System.EventHandler(this.fComentario_Load);
            this.tabComentario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComentario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabComentario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewComentario;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelIdComentario;
    }
}

