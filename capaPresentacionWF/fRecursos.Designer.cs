namespace capaPresentacionWF
{
    partial class fRecursos
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
            this.tabRecursos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombrer = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombrer = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRecursos = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabRecursos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRecursos
            // 
            this.tabRecursos.Controls.Add(this.tabPage1);
            this.tabRecursos.Controls.Add(this.tabPage2);
            this.tabRecursos.Location = new System.Drawing.Point(0, 0);
            this.tabRecursos.Name = "tabRecursos";
            this.tabRecursos.SelectedIndex = 0;
            this.tabRecursos.Size = new System.Drawing.Size(765, 396);
            this.tabRecursos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxDescripcion);
            this.tabPage1.Controls.Add(this.textBoxCodigo);
            this.tabPage1.Controls.Add(this.textBoxNombrer);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelDescripcion);
            this.tabPage1.Controls.Add(this.labelCodigo);
            this.tabPage1.Controls.Add(this.labelNombrer);
            this.tabPage1.Controls.Add(this.labelId);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.Location = new System.Drawing.Point(308, 320);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(153, 39);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(233, 217);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(342, 76);
            this.textBoxDescripcion.TabIndex = 8;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(233, 173);
            this.textBoxCodigo.Multiline = true;
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(342, 23);
            this.textBoxCodigo.TabIndex = 7;
            // 
            // textBoxNombrer
            // 
            this.textBoxNombrer.Location = new System.Drawing.Point(233, 134);
            this.textBoxNombrer.Multiline = true;
            this.textBoxNombrer.Name = "textBoxNombrer";
            this.textBoxNombrer.Size = new System.Drawing.Size(342, 23);
            this.textBoxNombrer.TabIndex = 6;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(233, 93);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(342, 23);
            this.textBoxId.TabIndex = 5;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDescripcion.Location = new System.Drawing.Point(108, 232);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(119, 24);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCodigo.Location = new System.Drawing.Point(145, 173);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(71, 24);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "Código";
            // 
            // labelNombrer
            // 
            this.labelNombrer.AutoSize = true;
            this.labelNombrer.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombrer.Location = new System.Drawing.Point(145, 129);
            this.labelNombrer.Name = "labelNombrer";
            this.labelNombrer.Size = new System.Drawing.Size(82, 24);
            this.labelNombrer.TabIndex = 2;
            this.labelNombrer.Text = "Nombre";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelId.Location = new System.Drawing.Point(145, 88);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(36, 24);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(246, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Recursos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewRecursos);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(276, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "Información";
            // 
            // dataGridViewRecursos
            // 
            this.dataGridViewRecursos.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecursos.Location = new System.Drawing.Point(36, 165);
            this.dataGridViewRecursos.Name = "dataGridViewRecursos";
            this.dataGridViewRecursos.Size = new System.Drawing.Size(670, 194);
            this.dataGridViewRecursos.TabIndex = 5;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminar.Location = new System.Drawing.Point(538, 116);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(140, 31);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditar.Location = new System.Drawing.Point(636, 77);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(110, 28);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Location = new System.Drawing.Point(474, 79);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(112, 27);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(109, 79);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(329, 26);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBuscar.Location = new System.Drawing.Point(10, 82);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 24);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar";
            // 
            // fRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 393);
            this.Controls.Add(this.tabRecursos);
            this.Name = "fRecursos";
            this.Text = "Recursos";
            this.Load += new System.EventHandler(this.fRecursos_Load);
            this.tabRecursos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRecursos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombrer;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombrer;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.DataGridView dataGridViewRecursos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label2;
    }
}

