namespace pryComettoClinica
{
    partial class frmPrincipal
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
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.cmbEspecialidadM = new System.Windows.Forms.ComboBox();
            this.mrcConsultas = new System.Windows.Forms.GroupBox();
            this.lblEspecialidadC = new System.Windows.Forms.Label();
            this.cmbEspecialidadC = new System.Windows.Forms.ComboBox();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.btnRegistrarM = new System.Windows.Forms.Button();
            this.mrcEspecialidad = new System.Windows.Forms.GroupBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblNumeroE = new System.Windows.Forms.Label();
            this.txtNumeroE = new System.Windows.Forms.TextBox();
            this.mrcRegistroM = new System.Windows.Forms.GroupBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.mrcConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.mrcEspecialidad.SuspendLayout();
            this.mrcRegistroM.SuspendLayout();
            this.mrcRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Location = new System.Drawing.Point(130, 83);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarE.TabIndex = 0;
            this.btnRegistrarE.Text = "Registrar";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(56, 45);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(149, 20);
            this.txtNombreE.TabIndex = 1;
            // 
            // cmbEspecialidadM
            // 
            this.cmbEspecialidadM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadM.FormattingEnabled = true;
            this.cmbEspecialidadM.Location = new System.Drawing.Point(79, 69);
            this.cmbEspecialidadM.Name = "cmbEspecialidadM";
            this.cmbEspecialidadM.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidadM.TabIndex = 3;
            // 
            // mrcConsultas
            // 
            this.mrcConsultas.Controls.Add(this.lblEspecialidadC);
            this.mrcConsultas.Controls.Add(this.cmbEspecialidadC);
            this.mrcConsultas.Controls.Add(this.dgvConsultas);
            this.mrcConsultas.Location = new System.Drawing.Point(6, 163);
            this.mrcConsultas.Name = "mrcConsultas";
            this.mrcConsultas.Size = new System.Drawing.Size(428, 218);
            this.mrcConsultas.TabIndex = 4;
            this.mrcConsultas.TabStop = false;
            this.mrcConsultas.Text = "Consultas";
            // 
            // lblEspecialidadC
            // 
            this.lblEspecialidadC.AutoSize = true;
            this.lblEspecialidadC.Location = new System.Drawing.Point(6, 16);
            this.lblEspecialidadC.Name = "lblEspecialidadC";
            this.lblEspecialidadC.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidadC.TabIndex = 15;
            this.lblEspecialidadC.Text = "Especialidad";
            // 
            // cmbEspecialidadC
            // 
            this.cmbEspecialidadC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidadC.FormattingEnabled = true;
            this.cmbEspecialidadC.Location = new System.Drawing.Point(79, 13);
            this.cmbEspecialidadC.Name = "cmbEspecialidadC";
            this.cmbEspecialidadC.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidadC.TabIndex = 14;
            this.cmbEspecialidadC.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidadC_SelectedIndexChanged);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nombre,
            this.especialidad});
            this.dgvConsultas.Location = new System.Drawing.Point(6, 40);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.Size = new System.Drawing.Size(416, 172);
            this.dgvConsultas.TabIndex = 0;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(79, 43);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(121, 20);
            this.txtNombreM.TabIndex = 6;
            // 
            // btnRegistrarM
            // 
            this.btnRegistrarM.Location = new System.Drawing.Point(125, 109);
            this.btnRegistrarM.Name = "btnRegistrarM";
            this.btnRegistrarM.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarM.TabIndex = 5;
            this.btnRegistrarM.Text = "Registrar";
            this.btnRegistrarM.UseVisualStyleBackColor = true;
            this.btnRegistrarM.Click += new System.EventHandler(this.btnRegistrarM_Click);
            // 
            // mrcEspecialidad
            // 
            this.mrcEspecialidad.Controls.Add(this.lblNombreE);
            this.mrcEspecialidad.Controls.Add(this.lblNumeroE);
            this.mrcEspecialidad.Controls.Add(this.txtNumeroE);
            this.mrcEspecialidad.Controls.Add(this.txtNombreE);
            this.mrcEspecialidad.Controls.Add(this.btnRegistrarE);
            this.mrcEspecialidad.Location = new System.Drawing.Point(6, 19);
            this.mrcEspecialidad.Name = "mrcEspecialidad";
            this.mrcEspecialidad.Size = new System.Drawing.Size(213, 113);
            this.mrcEspecialidad.TabIndex = 7;
            this.mrcEspecialidad.TabStop = false;
            this.mrcEspecialidad.Text = "Especialidad";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(6, 48);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(44, 13);
            this.lblNombreE.TabIndex = 10;
            this.lblNombreE.Text = "Nombre";
            // 
            // lblNumeroE
            // 
            this.lblNumeroE.AutoSize = true;
            this.lblNumeroE.Location = new System.Drawing.Point(31, 22);
            this.lblNumeroE.Name = "lblNumeroE";
            this.lblNumeroE.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroE.TabIndex = 9;
            this.lblNumeroE.Text = "Nº";
            // 
            // txtNumeroE
            // 
            this.txtNumeroE.Location = new System.Drawing.Point(56, 19);
            this.txtNumeroE.Name = "txtNumeroE";
            this.txtNumeroE.Size = new System.Drawing.Size(72, 20);
            this.txtNumeroE.TabIndex = 2;
            // 
            // mrcRegistroM
            // 
            this.mrcRegistroM.Controls.Add(this.lblEspecialidad);
            this.mrcRegistroM.Controls.Add(this.lblNombreM);
            this.mrcRegistroM.Controls.Add(this.lblMatricula);
            this.mrcRegistroM.Controls.Add(this.txtMatricula);
            this.mrcRegistroM.Controls.Add(this.txtNombreM);
            this.mrcRegistroM.Controls.Add(this.cmbEspecialidadM);
            this.mrcRegistroM.Controls.Add(this.btnRegistrarM);
            this.mrcRegistroM.Location = new System.Drawing.Point(225, 19);
            this.mrcRegistroM.Name = "mrcRegistroM";
            this.mrcRegistroM.Size = new System.Drawing.Size(209, 138);
            this.mrcRegistroM.TabIndex = 8;
            this.mrcRegistroM.TabStop = false;
            this.mrcRegistroM.Text = "Médico";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(6, 72);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 13;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(23, 46);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(44, 13);
            this.lblNombreM.TabIndex = 12;
            this.lblNombreM.Text = "Nombre";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(23, 20);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 11;
            this.lblMatricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(79, 17);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.mrcEspecialidad);
            this.mrcRegistro.Controls.Add(this.mrcRegistroM);
            this.mrcRegistro.Controls.Add(this.mrcConsultas);
            this.mrcRegistro.Location = new System.Drawing.Point(12, 12);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(443, 386);
            this.mrcRegistro.TabIndex = 8;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 403);
            this.Controls.Add(this.mrcRegistro);
            this.Name = "frmPrincipal";
            this.Text = "Registro de Médicos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mrcConsultas.ResumeLayout(false);
            this.mrcConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.mrcEspecialidad.ResumeLayout(false);
            this.mrcEspecialidad.PerformLayout();
            this.mrcRegistroM.ResumeLayout(false);
            this.mrcRegistroM.PerformLayout();
            this.mrcRegistro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.ComboBox cmbEspecialidadM;
        private System.Windows.Forms.GroupBox mrcConsultas;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Button btnRegistrarM;
        private System.Windows.Forms.GroupBox mrcEspecialidad;
        private System.Windows.Forms.GroupBox mrcRegistroM;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblNumeroE;
        private System.Windows.Forms.TextBox txtNumeroE;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblEspecialidadC;
        private System.Windows.Forms.ComboBox cmbEspecialidadC;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
    }
}

