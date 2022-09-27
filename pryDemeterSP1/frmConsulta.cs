using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDemeterSP1
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            dgvConsultaCultivos.Rows.Clear();
            StreamReader srLeectorProduccion = new StreamReader("./Toneladas.txt");

            while (!srLeectorProduccion.EndOfStream)
            {
                string varProduccion = srLeectorProduccion.ReadLine();
                string[] vecProduccion = varProduccion.Split(',');
                dgvConsultaCultivos.Rows.Add(vecProduccion[1], vecProduccion[0], vecProduccion[2], vecProduccion[3]);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
