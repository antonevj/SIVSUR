using ISVSUR.DATA;
using ISVSUR.Entity;
using ISVSUR.Logic;
using ISVSUR.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.UI
{
    public partial class Formulario_de_Venta : Form
    {
         string id;
       // int cont=1;
        public byte operacion { get; set; }
       // public object Reservado=1;
        public Formulario_de_Venta(string id)
        {
            InitializeComponent();
              this.id = id;
        }

        
        

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }








        private void Formulario_de_Venta_Load(object sender, EventArgs e)
        {

           

        }

        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
           
            ClientesIU f = new ClientesIU();
            f.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ruta ruta = new Ruta();
            ruta.ShowDialog();
        }

        private void Formulario_de_Venta_Activated(object sender, EventArgs e)
        {
            ///rutas
            txtIDRuta.Text = Program.IDRuta + "";
            txtOrigen.Text = Program.Ciudad_De_Origen + "";
            txtDestino.Text = Program.Ciudad_De_Destino + "";
            txtImporte.Text = Program.Precio + "";
            txtFecha.Text = Program.Fecha_De_Viaje + "";
            txtHora.Text = Program.Hora_De_Salida + "";


            //clientes

            txtIDCliente.Text = Program.IDCliente + "";
            txtDNI.Text = Program.DNI + "";
            txtNombre.Text = Program.Nombres + "";
            txtPaterno.Text = Program.Apellidos + "";
            txtSexo.Text = Program.sexo + "";
            txtEdad.Text = Program.edad + "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // cont=2;
            //   pictureBox2.Image = Image.FromFile(Application.StartupPath + "//Imagen//" + "asiento.jpg");

          
              //  pictureBox2.Image = Image.FromFile(Application.StartupPath + "//Imagen//" + "asiento.jpg");
               
           

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private bool MyValidation()
        {
            bool rpta = false;

            //arrary que almacena la coleccion de errores
            bool[] error = new bool[3];


            ///validamos el campo nombre 
            if (String.IsNullOrWhiteSpace(txtDNI.Text))
            {
                errorProvider1.SetError(txtDNI, "El DNI es obligatorio");
                error[0] = true;

            }


            //colocar las demas validaciones
            if (error[0] == true || error[1] == true)
            {
                MessageBox.Show("Error de validación.\n" + "Ingrese los datos en los campos obligatorios o verifique que estos sean válidos",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                rpta = false;
            }
            else
            {
                rpta = true;
            }




            return rpta;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
         
            if (!MyValidation())
            {


                return;

            }

            EVentas obj = new EVentas
            {

                IDCliente =Convert.ToInt32(txtIDCliente.Text),
                IDRuta = Convert.ToInt32(txtIDRuta.Text),
                IDAdmin = Convert.ToInt32(txtIDRecepcionista.Text),
                Asiento =Convert.ToInt32(lblAsiento.Text),
                LugarAsiento = txtLugar.Text,
                Fecha_De_Venta =Convert.ToDateTime(dtFechaHoy.Text),
                Reservado =checkBox1.Checked


            };

            int rpta=0;
           
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LVentas().Create(obj);

            }
          


            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
           

        }

        private void label17_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "3";
                txtLugar.Text = "pasillo";
            }
        }
        private void label18_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "4";
                txtLugar.Text = "ventana";
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "8";
                txtLugar.Text = "ventana";
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "8";
                txtLugar.Text = "pasillo";
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "12";
                txtLugar.Text = "ventana";
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "11";
                txtLugar.Text = "pasillo";
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "16";
                txtLugar.Text = "ventana";
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "15";
                txtLugar.Text = "pasillo";
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "2";
                txtLugar.Text = "pasillo";
            }
        }

        private void label15_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "1";
                txtLugar.Text = "ventana";
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "5";
                txtLugar.Text = "ventana";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "6";
                txtLugar.Text = "ventana";
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "10";
                txtLugar.Text = "pasillo";
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "9";
                txtLugar.Text = "ventana";
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "14";
                txtLugar.Text = "pasillo";
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "13";
                txtLugar.Text = "ventana";
            }
        }

        private void label43_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "20";
                txtLugar.Text = "ventana";
            }
        }

        private void label44_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "19";
                txtLugar.Text = "pasillo";
            }
        }

        private void label45_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "18";
                txtLugar.Text = "pasillo";
            }
        }

        private void label46_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "18";
                txtLugar.Text = "ventana";
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "21";
                txtLugar.Text = "ventana";
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "22";
                txtLugar.Text = "pasillo";
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "23";
                txtLugar.Text = "pasillo";
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "24";
                txtLugar.Text = "pasillo";
            }
        }

        private void label76_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "28";
                txtLugar.Text = "venta";
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "27";
                txtLugar.Text = "pasillo";
            }
        }

        private void label36_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "26";
                txtLugar.Text = "pasillo";
            }
        }

        private void label37_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "25";
                txtLugar.Text = "ventana";
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "29";
                txtLugar.Text = "ventana";
            }
        }

        private void label77_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "29";
                txtLugar.Text = "pasillo";
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "31";
                txtLugar.Text = "ventana";
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "32";
                txtLugar.Text = "pasillo";
            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "36";
                txtLugar.Text = "ventana";
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "35";
                txtLugar.Text = "pasillo";
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "34";
                txtLugar.Text = "pasillo";
            }
        }

        private void label50_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "33";
                txtLugar.Text = "ventana";
            }
        }

        private void label51_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "40";
                txtLugar.Text = "ventana";
            }
        }

        private void label61_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "39";
                txtLugar.Text = "pasillo";
            }
        }

        private void label62_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "38";
                txtLugar.Text = "pasillo";
            }
        }

        private void label63_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "37";
                txtLugar.Text = "ventana";
            }
        }

        private void label52_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "41";
                txtLugar.Text = "ventana";
            }
        }

        private void label64_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "42";
                txtLugar.Text = "pasillo";
            }
        }

        private void label78_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "43";
                txtLugar.Text = "pasillo";
            }
        }

        private void label79_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "44";
                txtLugar.Text = "ventana";
            }
        }

        private void label57_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "48";
                txtLugar.Text = "ventana";
            }
        }

        private void label58_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "47";
                txtLugar.Text = "pasillo";
            }
        }

        private void label59_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "46";
                txtLugar.Text = "pasillo";
            }
        }

        private void label60_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "45";
                txtLugar.Text = "ventana";
            }
        }

        private void label80_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "49";
                txtLugar.Text = "ventana";
            }
        }

        private void label81_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "50";
                txtLugar.Text = "pasillo";
            }
        }

        private void label82_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "51";
                txtLugar.Text = "pasillo";
            }
        }

        private void label83_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "52";
                txtLugar.Text = "ventana";
            }
        }

        private void label84_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "56";
                txtLugar.Text = "ventana";
            }
        }

        private void label85_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "55";
                txtLugar.Text = "pasillo";
            }
        }

        private void label86_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "54";
                txtLugar.Text = "pasillo";
            }
        }

        private void label87_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "53";
                txtLugar.Text = "ventana";
            }
        }
    }
}
