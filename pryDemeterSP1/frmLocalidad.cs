using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryDemeterSP1
{
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            //StreamWriter localidades = new StreamWriter("./Localidades.txt", true);
            //localidades.WriteLine(mskNumeroLocalidad.Text + "," + txtLocalidad.Text);
            //MessageBox.Show("Localidad cargada con exito");
            //localidades.Close();
            //txtLocalidad.Text = "";
            //mskNumeroLocalidad.Text = "";
            if (mskNumeroLocalidad.Text != "" && txtLocalidad.Text != "")
            {
                StreamWriter localidades = new StreamWriter("./Localidades.txt", true);     //Creo el archivo
                localidades.Close();          //Cierro el archivo localidades
                bool bandera = false;
                StreamReader numeros = new StreamReader("./Localidades.txt");    //leo el archivo localidades
                char varSeparador = Convert.ToChar(",");




                while (!numeros.EndOfStream)
                {
                    string[] vecnombrenumeros = numeros.ReadLine().Split(varSeparador);


                    if (mskNumeroLocalidad.Text == vecnombrenumeros[0])
                    {
                        MessageBox.Show("No se puede cargar, los datos ya existen");
                        bandera = true;
                    }
                }
                numeros.Close();              //cierro el archivo localidades
                if (bandera == false)
                {
                    StreamWriter grabar = new StreamWriter("./Localidades.txt", true);      //abro el archivo para guardar
                    grabar.WriteLine(mskNumeroLocalidad.Text + "," + txtLocalidad.Text);
                    MessageBox.Show("Se grabaron los datos");
                    grabar.Close();
                    txtLocalidad.Text = "";
                    mskNumeroLocalidad.Text = "";
                }
                else
                {
                    mskNumeroLocalidad.Text = "";
                    txtLocalidad.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            



        }

        private void frmLocalidad_Load(object sender, EventArgs e)
        {
            //if (txtLocalidad.Text != "" && mskNumeroLocalidad.Text != "")
            //{
            //    cmdCrear.Enabled = true;
            //}
            //else
            //{
            //    cmdCrear.Enabled = false;
            //}
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
