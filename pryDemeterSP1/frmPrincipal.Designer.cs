namespace pryDemeterSP1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmManteinimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLocalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCultivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProduccion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManteinimiento,
            this.tsmConsulta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "msAgricultura";
            // 
            // tsmManteinimiento
            // 
            this.tsmManteinimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLocalidades,
            this.tsmCultivos,
            this.tsmProduccion,
            this.tsmSalir});
            this.tsmManteinimiento.Name = "tsmManteinimiento";
            this.tsmManteinimiento.Size = new System.Drawing.Size(101, 20);
            this.tsmManteinimiento.Text = "Mantenimiento";
            // 
            // tsmLocalidades
            // 
            this.tsmLocalidades.Name = "tsmLocalidades";
            this.tsmLocalidades.Size = new System.Drawing.Size(180, 22);
            this.tsmLocalidades.Text = "Localidades";
            this.tsmLocalidades.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // tsmCultivos
            // 
            this.tsmCultivos.Name = "tsmCultivos";
            this.tsmCultivos.Size = new System.Drawing.Size(180, 22);
            this.tsmCultivos.Text = "Cultivos";
            this.tsmCultivos.Click += new System.EventHandler(this.cultivosToolStripMenuItem_Click);
            // 
            // tsmProduccion
            // 
            this.tsmProduccion.Name = "tsmProduccion";
            this.tsmProduccion.Size = new System.Drawing.Size(180, 22);
            this.tsmProduccion.Text = "Producción";
            this.tsmProduccion.Click += new System.EventHandler(this.producciónToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmConsulta
            // 
            this.tsmConsulta.Name = "tsmConsulta";
            this.tsmConsulta.Size = new System.Drawing.Size(71, 20);
            this.tsmConsulta.Text = "Consultas";
            this.tsmConsulta.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 132);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPrincipal";
            this.Text = "Agricultura - SP1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmManteinimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmLocalidades;
        private System.Windows.Forms.ToolStripMenuItem tsmCultivos;
        private System.Windows.Forms.ToolStripMenuItem tsmConsulta;
        private System.Windows.Forms.ToolStripMenuItem tsmProduccion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
    }
}

