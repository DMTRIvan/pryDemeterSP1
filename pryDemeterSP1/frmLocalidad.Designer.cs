namespace pryDemeterSP1
{
    partial class frmLocalidad
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
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.mskNumeroLocalidad = new System.Windows.Forms.MaskedTextBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(148, 39);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(28, 42);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(104, 13);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Nombre de localidad";
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Location = new System.Drawing.Point(28, 9);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(65, 13);
            this.lblIdentificador.TabIndex = 4;
            this.lblIdentificador.Text = "Identificador";
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(173, 91);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 6;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // mskNumeroLocalidad
            // 
            this.mskNumeroLocalidad.Location = new System.Drawing.Point(148, 9);
            this.mskNumeroLocalidad.Mask = "99999";
            this.mskNumeroLocalidad.Name = "mskNumeroLocalidad";
            this.mskNumeroLocalidad.Size = new System.Drawing.Size(100, 20);
            this.mskNumeroLocalidad.TabIndex = 7;
            this.mskNumeroLocalidad.ValidatingType = typeof(int);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(31, 91);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 135);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.mskNumeroLocalidad);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.lblIdentificador);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.txtLocalidad);
            this.Name = "frmLocalidad";
            this.Text = "frmLocalidad";
            this.Load += new System.EventHandler(this.frmLocalidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblIdentificador;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.MaskedTextBox mskNumeroLocalidad;
        private System.Windows.Forms.Button cmdSalir;
    }
}