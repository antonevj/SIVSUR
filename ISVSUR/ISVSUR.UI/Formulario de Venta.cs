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
        string id, nombres,apellidos;


        int total = 0;
        int num = 0;

        bool re;

        public byte operacion { get; set; }
      


        public Formulario_de_Venta(string id, string nombres,string apellidos)
        {
            InitializeComponent();
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
        }




        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }








        private void Formulario_de_Venta_Load(object sender, EventArgs e)
        {
            limpiar();

            dataGridView1.DataSource = new LVentas().GetAll(checkBox1.Checked);
       
            txtIDRecepcionista.Text = id;


            reservados();

        }



        private void reservados()
        {


            foreach (Control obj in groupBox3.Controls)
            {



                for (int x = 0; x <= dataGridView1.RowCount - 1; x++)
                {
                    if (obj is Label)
                    {

                        num = int.Parse(obj.Text);
                        total = Convert.ToInt32(dataGridView1.Rows[x].Cells[12].Value.ToString());

                        re = Convert.ToBoolean(dataGridView1.Rows[x].Cells[16].Value.ToString());


                        if (num == total && re == true)
                            obj.BackColor = Color.DarkRed;




                        if (obj.BackColor == Color.DarkRed)
                        {
                            obj.Enabled = false;
                        }
                    }

                }
            }






        }
        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {

            ClientesIU f = new ClientesIU();
            f.ShowDialog();
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
       //    int IDVenta;

            if (!MyValidation())
            {


                return;

            }

            EVentas obj = new EVentas
            {
             
                IDCliente = Convert.ToInt32(txtIDCliente.Text),
                IDRuta = Convert.ToInt32(txtIDRuta.Text),
                IDAdmin = Convert.ToInt32(txtIDRecepcionista.Text),
                Asiento = Convert.ToInt32(lblAsiento.Text),
                LugarAsiento = txtLugar.Text,
                Fecha_De_Venta = Convert.ToDateTime(dtFechaHoy.Text),
                Reservado = checkBox1.Checked


            };

            int rpta = 0;
            rpta = new LVentas().Create(obj);




            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;



               
                Boleta fv = new Boleta(nombres,apellidos);
             
                fv.lblNombres.Text = txtNombre.Text.ToString();
                fv.lblApellidos.Text = txtPaterno.Text;
                fv.lblOrigen.Text = txtOrigen.Text;
                fv.lblDestino.Text = txtDestino.Text;
                fv.lblFechaViaje.Text = txtFecha.Text;
                fv.lblHoraSalida.Text = txtHora.Text;
                fv.lblDNI.Text = txtDNI.Text;
                fv.lblValorVenta.Text = txtImporte.Text;
                fv.lblAsiento.Text = lblAsiento.Text;
                fv.lblLugarAsiento.Text = txtLugar.Text;
                fv.lblFechaExpedicion.Text = dtFechaHoy.Text;
                fv.lblPrecioTotal.Text = txtImporte.Text;
                fv.lblLetrasTotal.Text =enletras(txtImporte.Text).ToUpper()+" CON 00/100 NUEVOS SOLES";
                fv.ShowDialog();
            }


            reservados();
            limpiar();
        }

        public string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch


            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }

    


    private void limpiar()
        {

          
            txtOrigen.Text = "";
            txtDestino.Text = "";
            txtImporte.Text = "";
            txtFecha.Text =  "";
            txtHora.Text =  "";
            txtLugar.Text = "";
            lblAsiento.Text = "";

            //clientes

         
            txtDNI.Text = "";
            txtNombre.Text =  "";
            txtPaterno.Text = "";
            txtSexo.Text = "";
            txtEdad.Text = "";
            txtVuelto.Text = "";
            txtImporte.Text = "";
            txtImportepago.Text = "";


        }
        private void btnLimpia_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void label76_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
           

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

        private void label15_Click_2(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "1";
                txtLugar.Text = "ventana";
            }
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "2";
                txtLugar.Text = "pasillo";
            }
        }

        private void label17_Click_1(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  de vaciar los asientos", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                bool r = false;
                dataGridView1.DataSource = new LVentas().Modificar(r);
                modificar();
            }
           

          
        }


        private void modificar()
        {

            foreach (Control obj in groupBox3.Controls)
            {



                  if (obj is Label)
                    {
                   
                       if (obj.BackColor==Color.DarkRed)
                        {
                            obj.BackColor = Color.DeepSkyBlue;
                            obj.Enabled = true;
                        }
                          
                    }

                
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
                txtLugar.Text = "pasillo";
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "7";
                txtLugar.Text = "pasillo";
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

        private void label23_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "9";
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

        private void label25_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "11";
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

        private void label27_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "13";
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

        private void label29_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "15";
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

        private void label46_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "17";
                txtLugar.Text = "ventana";
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

        private void label44_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "19";
                txtLugar.Text = "pasillo";
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
                txtLugar.Text = "ventana";
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

        private void label36_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "26";
                txtLugar.Text = "pasillo";
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

        private void label76_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "28";
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
                lblAsiento.Text = "30";
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

        private void label50_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "33";
                txtLugar.Text = "ventana";
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

        private void label31_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "35";
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

        private void label63_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "37";
                txtLugar.Text = "ventana";
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

        private void label61_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "39";
                txtLugar.Text = "pasillo";
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

        private void label60_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "45";
                txtLugar.Text = "ventana";
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

        private void label58_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "47";
                txtLugar.Text = "pasillo";
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

        private void label87_Click_1(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "53";
                txtLugar.Text = "ventana";
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

        private void txtImportepago_Leave(object sender, EventArgs e)
        {

            decimal n1, n2, r;
            n1 = decimal.Parse(txtImportepago.Text);
            n2 =decimal.Parse( txtImporte.Text);
            if (txtImportepago.Text!="" || txtImporte.Text!="")
            {
                r = n1 - n2;
                txtVuelto.Text = r.ToString();
            }
            else
            {
                MessageBox.Show("debe ingresar el precio del pasaje");
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

        private void label84_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                lblAsiento.Text = "56";
                txtLugar.Text = "ventana";
            }
        }
    }
}
