using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDemeterSP1
{
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {

        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            if (mskNumeroCultivo.Text != "" && txtNombre.Text != "")
            {
                //StreamWriter cultivos = new StreamWriter("./Cultivos.txt", true);
                //cultivos.WriteLine(mskNumeroCultivo.Text + "," + txtNombre.Text);
                //MessageBox.Show("Cultivo cargado con exito");
                //cultivos.Close();
                //txtNombre.Text = "";
                //mskNumeroCultivo.Text = "";
                StreamWriter cultivos = new StreamWriter("./cultivos.txt", true);     //Creo el archivo
                cultivos.Close();          //Cierro el archivo localidades
                bool bandera = false;
                StreamReader numeros = new StreamReader("./cultivos.txt");    //leo el archivo localidades
                char varSeparador = Convert.ToChar(",");




                while (!numeros.EndOfStream)
                {
                    string[] vecnombrenumeros = numeros.ReadLine().Split(varSeparador);


                    if (mskNumeroCultivo.Text == vecnombrenumeros[0])
                    {
                        MessageBox.Show("No se puede cargar, los datos ya existen");
                        bandera = true;
                    }
                }
                numeros.Close();              //cierro el archivo localidades
                if (bandera == false)
                {
                    StreamWriter grabar = new StreamWriter("./cultivos.txt", true);      //abro el archivo para guardar
                    grabar.WriteLine(mskNumeroCultivo.Text + "," + txtNombre.Text);
                    MessageBox.Show("Se grabaron los datos");
                    grabar.Close();
                    txtNombre.Text = "";
                    mskNumeroCultivo.Text = "";
                }
                else
                {
                    mskNumeroCultivo.Text = "";
                    txtNombre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            




        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
