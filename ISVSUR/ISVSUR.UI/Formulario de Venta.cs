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
    public partial class Formulario_de_Venta : Form
    {
        public Formulario_de_Venta()
        {
            InitializeComponent();
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

     
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            lblAsiento.Text = "4";
        }
    }
}
