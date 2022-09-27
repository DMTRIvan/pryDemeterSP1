namespace pryDemeterSP1
{
    partial class frmProducción
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
            this.lblNombreDeLocalidad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombreDelCultivo = new System.Windows.Forms.Label();
            this.lstLocalidad = new System.Windows.Forms.ComboBox();
            this.lstCultivo = new System.Windows.Forms.ComboBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mskCantidadToneladas = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNombreDeLocalidad
            // 
            this.lblNombreDeLocalidad.AutoSize = true;
            this.lblNombreDeLocalidad.Location = new System.Drawing.Point(12, 34);
            this.lblNombreDeLocalidad.Name = "lblNombreDeLocalidad";
            this.lblNombreDeLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblNombreDeLocalidad.TabIndex = 1;
            this.lblNombreDeLocalidad.Text = "Localidad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 127);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad (Toneladas)";
            // 
            // lblNombreDelCultivo
            // 
            this.lblNombreDelCultivo.AutoSize = true;
            this.lblNombreDelCultivo.Location = new System.Drawing.Point(12, 82);
            this.lblNombreDelCultivo.Name = "lblNombreDelCultivo";
            this.lblNombreDelCultivo.Size = new System.Drawing.Size(96, 13);
            this.lblNombreDelCultivo.TabIndex = 3;
            this.lblNombreDelCultivo.Text = "Nombre del Cultivo";
            // 
            // lstLocalidad
            // 
            this.lstLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstLocalidad.FormattingEnabled = true;
            this.lstLocalidad.Location = new System.Drawing.Point(139, 31);
            this.lstLocalidad.Name = "lstLocalidad";
            this.lstLocalidad.Size = new System.Drawing.Size(133, 21);
            this.lstLocalidad.TabIndex = 8;
            this.lstLocalidad.SelectedIndexChanged += new System.EventHandler(this.lstLocalidad_SelectedIndexChanged);
            // 
            // lstCultivo
            // 
            this.lstCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCultivo.FormattingEnabled = true;
            this.lstCultivo.Location = new System.Drawing.Point(139, 84);
            this.lstCultivo.Name = "lstCultivo";
            this.lstCultivo.Size = new System.Drawing.Size(133, 21);
            this.lstCultivo.TabIndex = 9;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(193, 211);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 10;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(15, 211);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // mskCantidadToneladas
            // 
            this.mskCantidadToneladas.Location = new System.Drawing.Point(139, 127);
            this.mskCantidadToneladas.Mask = "99999";
            this.mskCantidadToneladas.Name = "mskCantidadToneladas";
            this.mskCantidadToneladas.Size = new System.Drawing.Size(129, 20);
            this.mskCantidadToneladas.TabIndex = 12;
            this.mskCantidadToneladas.ValidatingType = typeof(int);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 170);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(41, 15);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // mskFecha
            // 
            this.mskFecha.Location = new System.Drawing.Point(139, 165);
            this.mskFecha.Margin = new System.Windows.Forms.Padding(2);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(129, 20);
            this.mskFecha.TabIndex = 14;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // frmProducción
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 277);
            this.Controls.Add(this.mskFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mskCantidadToneladas);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lstCultivo);
            this.Controls.Add(this.lstLocalidad);
            this.Controls.Add(this.lblNombreDelCultivo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombreDeLocalidad);
            this.Name = "frmProducción";
            this.Text = "frmProducción";
            this.Load += new System.EventHandler(this.frmProducción_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreDeLocalidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombreDelCultivo;
        private System.Windows.Forms.ComboBox lstLocalidad;
        private System.Windows.Forms.ComboBox lstCultivo;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.MaskedTextBox mskCantidadToneladas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mskFecha;
    }
}