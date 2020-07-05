using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.UI
{
    public partial class Boleta : Form
    {

        string  nombres,apellidos;
        public Boleta(string nombres,string apellidos)
        {
            InitializeComponent();
            this.nombres = nombres;
            this.apellidos = apellidos;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);

            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();

            this.Hide();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Boleta_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text =nombres+" "+ apellidos;

           
            int cont, conts;
            cont = int.Parse(lblNroCorrelativo.Text);
          
            cont++;
            lblNroCorrelativo.Text = "000" + cont.ToString();
           

            conts = int.Parse(lblSerie.Text);
                
            conts++;
            lblSerie.Text = "000" + conts.ToString();

            lblNroCorrelativo1.Text = lblNroCorrelativo.Text;
            lblSerie1.Text = lblSerie.Text;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

       


    }
}
