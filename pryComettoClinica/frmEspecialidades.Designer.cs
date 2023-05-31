namespace pryComettoClinica
{
    partial class frmEspecialidades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidades));
            this.mrcEspecialidad = new System.Windows.Forms.GroupBox();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblNumeroE = new System.Windows.Forms.Label();
            this.txtNumeroE = new System.Windows.Forms.TextBox();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.mrcEspecialidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcEspecialidad
            // 
            this.mrcEspecialidad.Controls.Add(this.lblNombreE);
            this.mrcEspecialidad.Controls.Add(this.lblNumeroE);
            this.mrcEspecialidad.Controls.Add(this.txtNumeroE);
            this.mrcEspecialidad.Controls.Add(this.txtNombreE);
            this.mrcEspecialidad.Controls.Add(this.btnRegistrarE);
            this.mrcEspecialidad.Location = new System.Drawing.Point(12, 12);
            this.mrcEspecialidad.Name = "mrcEspecialidad";
            this.mrcEspecialidad.Size = new System.Drawing.Size(301, 153);
            this.mrcEspecialidad.TabIndex = 7;
            this.mrcEspecialidad.TabStop = false;
            this.mrcEspecialidad.Text = "Especialidad";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(18, 68);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(44, 13);
            this.lblNombreE.TabIndex = 10;
            this.lblNombreE.Text = "Nombre";
            // 
            // lblNumeroE
            // 
            this.lblNumeroE.AutoSize = true;
            this.lblNumeroE.Location = new System.Drawing.Point(43, 42);
            this.lblNumeroE.Name = "lblNumeroE";
            this.lblNumeroE.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroE.TabIndex = 9;
            this.lblNumeroE.Text = "Nº";
            // 
            // txtNumeroE
            // 
            this.txtNumeroE.Location = new System.Drawing.Point(68, 39);
            this.txtNumeroE.Name = "txtNumeroE";
            this.txtNumeroE.Size = new System.Drawing.Size(72, 20);
            this.txtNumeroE.TabIndex = 0;
            // 
            // txtNombreE
            // 
            this.txtNombreE.Location = new System.Drawing.Point(68, 65);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(149, 20);
            this.txtNombreE.TabIndex = 1;
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Location = new System.Drawing.Point(220, 124);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarE.TabIndex = 2;
            this.btnRegistrarE.Text = "Registrar";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // frmEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 177);
            this.Controls.Add(this.mrcEspecialidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades - Clínica Genérica";
            this.mrcEspecialidad.ResumeLayout(false);
            this.mrcEspecialidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcEspecialidad;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblNumeroE;
        private System.Windows.Forms.TextBox txtNumeroE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Button btnRegistrarE;
    }
}