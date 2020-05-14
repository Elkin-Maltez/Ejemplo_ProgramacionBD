namespace capaPresentacionWF2
{
    partial class fSolicitud
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
            this.tabSolicitud = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxAsignatura = new System.Windows.Forms.TextBox();
            this.textBoxCarrera = new System.Windows.Forms.TextBox();
            this.textBoxHoraFinal = new System.Windows.Forms.TextBox();
            this.textBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.textBoxFechaUso = new System.Windows.Forms.TextBox();
            this.textBoxFechaSolicitud = new System.Windows.Forms.TextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxAula = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelAsignatura = new System.Windows.Forms.Label();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.labelHoraFinal = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelFechaUso = new System.Windows.Forms.Label();
            this.labelFechaSolicitud = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.labelAula = new System.Windows.Forms.Label();
            this.labelIdSolicitud = new System.Windows.Forms.Label();
            this.labelSolicitud = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSolicitud = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.tabSolicitud.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSolicitud
            // 
            this.tabSolicitud.Controls.Add(this.tabPage1);
            this.tabSolicitud.Controls.Add(this.tabPage2);
            this.tabSolicitud.Location = new System.Drawing.Point(1, 1);
            this.tabSolicitud.Name = "tabSolicitud";
            this.tabSolicitud.SelectedIndex = 0;
            this.tabSolicitud.Size = new System.Drawing.Size(800, 446);
            this.tabSolicitud.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.buttonGuardar);
            this.tabPage1.Controls.Add(this.textBoxAsignatura);
            this.tabPage1.Controls.Add(this.textBoxCarrera);
            this.tabPage1.Controls.Add(this.textBoxHoraFinal);
            this.tabPage1.Controls.Add(this.textBoxHoraInicio);
            this.tabPage1.Controls.Add(this.textBoxFechaUso);
            this.tabPage1.Controls.Add(this.textBoxFechaSolicitud);
            this.tabPage1.Controls.Add(this.textBoxNivel);
            this.tabPage1.Controls.Add(this.textBoxAula);
            this.tabPage1.Controls.Add(this.textBoxId);
            this.tabPage1.Controls.Add(this.labelAsignatura);
            this.tabPage1.Controls.Add(this.labelCarrera);
            this.tabPage1.Controls.Add(this.labelHoraFinal);
            this.tabPage1.Controls.Add(this.labelHoraInicio);
            this.tabPage1.Controls.Add(this.labelFechaUso);
            this.tabPage1.Controls.Add(this.labelFechaSolicitud);
            this.tabPage1.Controls.Add(this.labelNivel);
            this.tabPage1.Controls.Add(this.labelAula);
            this.tabPage1.Controls.Add(this.labelIdSolicitud);
            this.tabPage1.Controls.Add(this.labelSolicitud);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.Location = new System.Drawing.Point(317, 331);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(206, 43);
            this.buttonGuardar.TabIndex = 29;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxAsignatura
            // 
            this.textBoxAsignatura.Location = new System.Drawing.Point(571, 239);
            this.textBoxAsignatura.Multiline = true;
            this.textBoxAsignatura.Name = "textBoxAsignatura";
            this.textBoxAsignatura.Size = new System.Drawing.Size(203, 26);
            this.textBoxAsignatura.TabIndex = 28;
            // 
            // textBoxCarrera
            // 
            this.textBoxCarrera.Location = new System.Drawing.Point(571, 196);
            this.textBoxCarrera.Multiline = true;
            this.textBoxCarrera.Name = "textBoxCarrera";
            this.textBoxCarrera.Size = new System.Drawing.Size(203, 26);
            this.textBoxCarrera.TabIndex = 27;
            // 
            // textBoxHoraFinal
            // 
            this.textBoxHoraFinal.Location = new System.Drawing.Point(571, 154);
            this.textBoxHoraFinal.Multiline = true;
            this.textBoxHoraFinal.Name = "textBoxHoraFinal";
            this.textBoxHoraFinal.Size = new System.Drawing.Size(203, 26);
            this.textBoxHoraFinal.TabIndex = 26;
            // 
            // textBoxHoraInicio
            // 
            this.textBoxHoraInicio.Location = new System.Drawing.Point(571, 112);
            this.textBoxHoraInicio.Multiline = true;
            this.textBoxHoraInicio.Name = "textBoxHoraInicio";
            this.textBoxHoraInicio.Size = new System.Drawing.Size(203, 26);
            this.textBoxHoraInicio.TabIndex = 25;
            // 
            // textBoxFechaUso
            // 
            this.textBoxFechaUso.Location = new System.Drawing.Point(190, 259);
            this.textBoxFechaUso.Multiline = true;
            this.textBoxFechaUso.Name = "textBoxFechaUso";
            this.textBoxFechaUso.Size = new System.Drawing.Size(233, 26);
            this.textBoxFechaUso.TabIndex = 24;
            // 
            // textBoxFechaSolicitud
            // 
            this.textBoxFechaSolicitud.Location = new System.Drawing.Point(190, 217);
            this.textBoxFechaSolicitud.Multiline = true;
            this.textBoxFechaSolicitud.Name = "textBoxFechaSolicitud";
            this.textBoxFechaSolicitud.Size = new System.Drawing.Size(233, 26);
            this.textBoxFechaSolicitud.TabIndex = 23;
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(190, 174);
            this.textBoxNivel.Multiline = true;
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(233, 26);
            this.textBoxNivel.TabIndex = 22;
            // 
            // textBoxAula
            // 
            this.textBoxAula.Location = new System.Drawing.Point(190, 132);
            this.textBoxAula.Multiline = true;
            this.textBoxAula.Name = "textBoxAula";
            this.textBoxAula.Size = new System.Drawing.Size(233, 26);
            this.textBoxAula.TabIndex = 21;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(190, 90);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(233, 26);
            this.textBoxId.TabIndex = 20;
            // 
            // labelAsignatura
            // 
            this.labelAsignatura.AutoSize = true;
            this.labelAsignatura.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignatura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAsignatura.Location = new System.Drawing.Point(443, 243);
            this.labelAsignatura.Name = "labelAsignatura";
            this.labelAsignatura.Size = new System.Drawing.Size(113, 24);
            this.labelAsignatura.TabIndex = 19;
            this.labelAsignatura.Text = "Asignatura";
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrera.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCarrera.Location = new System.Drawing.Point(443, 200);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(80, 24);
            this.labelCarrera.TabIndex = 18;
            this.labelCarrera.Text = "Carrera";
            // 
            // labelHoraFinal
            // 
            this.labelHoraFinal.AutoSize = true;
            this.labelHoraFinal.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraFinal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHoraFinal.Location = new System.Drawing.Point(443, 158);
            this.labelHoraFinal.Name = "labelHoraFinal";
            this.labelHoraFinal.Size = new System.Drawing.Size(118, 24);
            this.labelHoraFinal.TabIndex = 17;
            this.labelHoraFinal.Text = "Hora Final";
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInicio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelHoraInicio.Location = new System.Drawing.Point(443, 116);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(122, 24);
            this.labelHoraInicio.TabIndex = 16;
            this.labelHoraInicio.Text = "Hora Inicio";
            // 
            // labelFechaUso
            // 
            this.labelFechaUso.AutoSize = true;
            this.labelFechaUso.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaUso.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFechaUso.Location = new System.Drawing.Point(27, 259);
            this.labelFechaUso.Name = "labelFechaUso";
            this.labelFechaUso.Size = new System.Drawing.Size(107, 24);
            this.labelFechaUso.TabIndex = 15;
            this.labelFechaUso.Text = "Fecha Uso";
            // 
            // labelFechaSolicitud
            // 
            this.labelFechaSolicitud.AutoSize = true;
            this.labelFechaSolicitud.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaSolicitud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFechaSolicitud.Location = new System.Drawing.Point(27, 217);
            this.labelFechaSolicitud.Name = "labelFechaSolicitud";
            this.labelFechaSolicitud.Size = new System.Drawing.Size(158, 24);
            this.labelFechaSolicitud.TabIndex = 14;
            this.labelFechaSolicitud.Text = "Fecha Solicitud";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNivel.Location = new System.Drawing.Point(27, 174);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(61, 24);
            this.labelNivel.TabIndex = 13;
            this.labelNivel.Text = "Nivel";
            // 
            // labelAula
            // 
            this.labelAula.AutoSize = true;
            this.labelAula.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAula.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelAula.Location = new System.Drawing.Point(27, 132);
            this.labelAula.Name = "labelAula";
            this.labelAula.Size = new System.Drawing.Size(56, 24);
            this.labelAula.TabIndex = 12;
            this.labelAula.Text = "Aula";
            this.labelAula.UseWaitCursor = true;
            // 
            // labelIdSolicitud
            // 
            this.labelIdSolicitud.AutoSize = true;
            this.labelIdSolicitud.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdSolicitud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIdSolicitud.Location = new System.Drawing.Point(27, 90);
            this.labelIdSolicitud.Name = "labelIdSolicitud";
            this.labelIdSolicitud.Size = new System.Drawing.Size(36, 24);
            this.labelIdSolicitud.TabIndex = 11;
            this.labelIdSolicitud.Text = "ID";
            // 
            // labelSolicitud
            // 
            this.labelSolicitud.AutoSize = true;
            this.labelSolicitud.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolicitud.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelSolicitud.Location = new System.Drawing.Point(258, 3);
            this.labelSolicitud.Name = "labelSolicitud";
            this.labelSolicitud.Size = new System.Drawing.Size(318, 59);
            this.labelSolicitud.TabIndex = 10;
            this.labelSolicitud.Text = "Registrar Solicitud";
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewSolicitud);
            this.tabPage2.Controls.Add(this.buttonEliminar);
            this.tabPage2.Controls.Add(this.buttonEditar);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textBoxBuscar);
            this.tabPage2.Controls.Add(this.labelBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR DECODE", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(296, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 59);
            this.label2.TabIndex = 13;
            this.label2.Text = "Información";
            // 
            // dataGridViewSolicitud
            // 
            this.dataGridViewSolicitud.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSolicitud.Location = new System.Drawing.Point(56, 211);
            this.dataGridViewSolicitud.Name = "dataGridViewSolicitud";
            this.dataGridViewSolicitud.Size = new System.Drawing.Size(670, 194);
            this.dataGridViewSolicitud.TabIndex = 12;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEliminar.Location = new System.Drawing.Point(558, 133);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(140, 31);
            this.buttonEliminar.TabIndex = 11;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditar.Location = new System.Drawing.Point(656, 94);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(110, 28);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "EDITAR";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.Location = new System.Drawing.Point(494, 96);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(112, 27);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(129, 96);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(329, 26);
            this.textBoxBuscar.TabIndex = 8;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBuscar.Location = new System.Drawing.Point(30, 99);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 24);
            this.labelBuscar.TabIndex = 7;
            this.labelBuscar.Text = "Buscar";
            // 
            // fSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabSolicitud);
            this.Name = "fSolicitud";
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.fSolicitud_Load);
            this.tabSolicitud.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSolicitud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSolicitud;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.TextBox textBoxAula;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelAsignatura;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.Label labelHoraFinal;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelFechaUso;
        private System.Windows.Forms.Label labelFechaSolicitud;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.Label labelAula;
        private System.Windows.Forms.Label labelIdSolicitud;
        private System.Windows.Forms.Label labelSolicitud;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxAsignatura;
        private System.Windows.Forms.TextBox textBoxCarrera;
        private System.Windows.Forms.TextBox textBoxHoraFinal;
        private System.Windows.Forms.TextBox textBoxHoraInicio;
        private System.Windows.Forms.TextBox textBoxFechaUso;
        private System.Windows.Forms.TextBox textBoxFechaSolicitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSolicitud;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
    }
}

