using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private string id;
        int cont=1;
        public Formulario_de_Venta()
        {
            InitializeComponent();
        }

        public Formulario_de_Venta(string id)
        {
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
           
            if (cont == 1 )
            {
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "//Imagen//" + "x.png"); 
                              
            }
            cont++;
           
        }

        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
            //ClientesIU fm = new ClientesIU();
            //fm.Size = new System.Drawing.Size(500, 400);
            ClientesIU f = new ClientesIU();
            f.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox2.Image = Image.FromFile(Application.StartupPath + "//Imagen//" + "x.png");
                pictureBox2.Enabled = false;
                lblAsiento.Text = "4";
                txtLugar.Text = "Ventana";

            }
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox16.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox16.Enabled = false;
                lblAsiento.Text = "1";
                txtLugar.Text = "Ventana";

            }

        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox17.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox17.Enabled = false;
                lblAsiento.Text = "2";
                txtLugar.Text = "Pasillo";

            }

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox3.Enabled = false;
                lblAsiento.Text = "3";
                txtLugar.Text = "pasillo";

            }
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox14.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox14.Enabled = false;
                lblAsiento.Text = "5";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox15.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox15.Enabled = false;
                lblAsiento.Text = "6";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox7.Enabled = false;
                lblAsiento.Text = "7";
                txtLugar.Text = "pasillo";

            }


        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox5.Enabled = false;
                lblAsiento.Text = "8";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox12.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox12.Enabled = false;
                lblAsiento.Text = "9";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox13.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox13.Enabled = false;
                lblAsiento.Text = "10";
                txtLugar.Text = "pasillo";
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox6.Enabled = false;
                lblAsiento.Text = "11";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox7.Enabled = false;
                lblAsiento.Text = "12";
                txtLugar.Text = "ventana";

            }


        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox10.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox10.Enabled = false;
                lblAsiento.Text = "13";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox11.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox11.Enabled = false;
                lblAsiento.Text = "14";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox8.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox8.Enabled = false;
                lblAsiento.Text = "15";
                txtLugar.Text = "pasillo";

            }


        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox9.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox9.Enabled = false;
                lblAsiento.Text = "16";
                txtLugar.Text = "ventana";

            }


        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox24.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox24.Enabled = false;
                lblAsiento.Text = "17";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                pictureBox25.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox25.Enabled = false;
                lblAsiento.Text = "18";
                txtLugar.Text = "pasillo";
            }
        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox32.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox32.Enabled = false;
                lblAsiento.Text = "19";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox33_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox33.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox33.Enabled = false;
                lblAsiento.Text = "20";
                txtLugar.Text = "ventana";
            }

        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                pictureBox22.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox22.Enabled = false;
                lblAsiento.Text = "21";
                txtLugar.Text = "ventana";
            }
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {
                pictureBox23.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox23.Enabled = false;
                lblAsiento.Text = "22";
                txtLugar.Text = "pasillo";
            }
        }

        private void PictureBox30_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox30.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox30.Enabled = false;
                lblAsiento.Text = "23";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox31.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox31.Enabled = false;
                lblAsiento.Text = "24";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox20.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox20.Enabled = false;
                lblAsiento.Text = "25";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox21.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox21.Enabled = false;
                lblAsiento.Text = "26";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox28_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox28.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox28.Enabled = false;
                lblAsiento.Text = "27";
                txtLugar.Text = "pasillo";

            }


        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox29.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox29.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox18.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox18.Enabled = false;
                lblAsiento.Text = "29";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox19.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox19.Enabled = false;
                lblAsiento.Text = "30";
                txtLugar.Text = "pasillo";
            }

        }

        private void PictureBox34_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox34.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox34.Enabled = false;
                lblAsiento.Text = "31";
                txtLugar.Text = "ventana";
            }

        }

        private void PictureBox35_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox35.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox35.Enabled = false;
                lblAsiento.Text = "32";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox36_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox36.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox36.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "33";
        }

        private void PictureBox37_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox37.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox37.Enabled = false;
                lblAsiento.Text = "34";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox26_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox26.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox26.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "pasillo";

            }

            lblAsiento.Text = "35";
        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox27.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox27.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "36";
        }

        private void PictureBox42_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox42.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox42.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "37";
        }

        private void PictureBox43_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox43.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox43.Enabled = false;
                lblAsiento.Text = "38";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox48_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox48.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox48.Enabled = false;
                lblAsiento.Text = "39";
                txtLugar.Text = "pasillo";
            }

        }

        private void PictureBox49_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox49.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox49.Enabled = false;
                lblAsiento.Text = "40";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox40_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox40.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox40.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "41";
        }

        private void PictureBox41_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox41.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox41.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "42";
        }

        private void PictureBox46_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox46.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox46.Enabled = false;
                lblAsiento.Text = "43";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox47_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox47.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox47.Enabled = false;
                lblAsiento.Text = "44";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox38_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox38.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox38.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "45";
        }

        private void PictureBox39_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox39.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox39.Enabled = false;
                lblAsiento.Text = "46";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox44_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox44.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox44.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "pasillo";

            }
            lblAsiento.Text = "47";
        }

        private void PictureBox45_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox45.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox45.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "48";
        }

        private void PictureBox52_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox52.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox52.Enabled = false;
                lblAsiento.Text = "49";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox53_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox53.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox53.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "pasillo";

            }
            lblAsiento.Text = "50";
        }

        private void PictureBox56_Click(object sender, EventArgs e)
        {

            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox56.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox56.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "pasillo";

            }
            lblAsiento.Text = "51";
        }

        private void PictureBox57_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox57.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox57.Enabled = false;
                lblAsiento.Text = "28";
                txtLugar.Text = "ventana";

            }
            lblAsiento.Text = "52";
        }

        private void PictureBox50_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox50.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox50.Enabled = false;
                lblAsiento.Text = "53";
                txtLugar.Text = "ventana";

            }

        }

        private void PictureBox51_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox51.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox51.Enabled = false;
                lblAsiento.Text = "54";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox54_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox54.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox54.Enabled = false;
                lblAsiento.Text = " 55";
                txtLugar.Text = "pasillo";

            }

        }

        private void PictureBox55_Click(object sender, EventArgs e)
        {
            DialogResult k = MessageBox.Show("Estas seguro  del asiento que elegiste?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (k == DialogResult.Yes)
            {

                pictureBox55.Image = Image.FromFile(Application.StartupPath + "\\Imagen\\" + "x.png");
                pictureBox55.Enabled = false;
                lblAsiento.Text = "56";
                txtLugar.Text = "ventana";

            }

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

          
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "//Imagen//" + "asiento.jpg");
               
           

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
