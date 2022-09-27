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
    public partial class frmProducción : Form
    {
        public frmProducción()
        {
            InitializeComponent();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (lstLocalidad.SelectedIndex != -1 && lstCultivo.SelectedIndex != -1 && mskCantidadToneladas.Text != "" && mskFecha.Text != "")
            {
                //StreamWriter produccion = new StreamWriter("./Produccion.txt", true);
                //produccion.WriteLine(txtToneladas.Text);
                //MessageBox.Show("Cantidad cargada con exito");
                //produccion.Close();
                //lstCultivo.SelectedIndex = -1;
                //lstLocalidad.SelectedIndex = -1;
                //txtToneladas.Text = "";

                StreamWriter Toneladas = new StreamWriter("./Toneladas.txt", true);     //Creo el archivo
                Toneladas.Close();          //Cierro el archivo localidades
                bool bandera = false;
                StreamReader numeros = new StreamReader("./Toneladas.txt");    //leo el archivo toneladas
                char varSeparador = Convert.ToChar(",");

                while (!numeros.EndOfStream)
                {
                    string[] vecToneladas = numeros.ReadLine().Split(varSeparador);
                    //lblMostrar1.Text = vecToneladas[0];
                    //lblMostrar2.Text = vecToneladas[1];
                    //lblMostrar3.Text = lstLocalidad.Text;
                    if (lstLocalidad.Text == vecToneladas[0] && lstCultivo.Text == vecToneladas[1])
                    {
                        MessageBox.Show("No se puede cargar");
                        bandera = true;
                    }
                }
                numeros.Close();              //cierro el archivo localidades
                if (bandera == false)
                {
                    StreamWriter grabar = new StreamWriter("./Toneladas.txt", true);      //abro el archivo para guardar
                    grabar.WriteLine(lstLocalidad.Text + "," + lstCultivo.Text + "," + mskCantidadToneladas.Text + "," + mskFecha.Text);
                    MessageBox.Show("Se grabaron los datos");
                    grabar.Close();
                    lstCultivo.SelectedIndex = -1;
                    lstLocalidad.SelectedIndex = -1;
                    mskCantidadToneladas.Text = "";
                    mskFecha.Text = "";
                }
                else
                {
                    lstCultivo.SelectedIndex = -1;
                    lstLocalidad.SelectedIndex = -1;
                    mskCantidadToneladas.Text = "";
                    mskFecha.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            




        }

        private void frmProducción_Load(object sender, EventArgs e)
        {
            StreamWriter lectorLocalida = new StreamWriter("./Localidades.txt", true);     //Creo el archivo
            lectorLocalida.Close();
            StreamWriter lectorCultivo = new StreamWriter("./Cultivos.txt", true);     //Creo el archivo
            lectorCultivo.Close();
            StreamReader lectorLocalidad = new StreamReader("./Localidades.txt");
            StreamReader lectorCultivos = new StreamReader("./Cultivos.txt");
            char varSeparador = Convert.ToChar(",");

            while (!lectorCultivos.EndOfStream)
            {
                string[] vecnombreCultivos = lectorCultivos.ReadLine().Split(varSeparador);
                lstCultivo.Items.Add(vecnombreCultivos[1]);

            }
            lectorCultivos.Close();

            while (!lectorLocalidad.EndOfStream)
            {
                string[] vecnombreLocalidad = lectorLocalidad.ReadLine().Split(varSeparador);
                lstLocalidad.Items.Add(vecnombreLocalidad[1]);

            }
            lectorLocalidad.Close();
        }

        private void lstLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
