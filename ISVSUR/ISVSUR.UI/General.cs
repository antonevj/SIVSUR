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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

            

        }


        private void General_Load(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_de_Venta CLi = new Formulario_de_Venta();
            CLi.Show();
        }

        private void btnVenta_ButtonClick(object sender, EventArgs e)
        {

        }

        private void cLientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClientesIU CLi = new ClientesIU();
            CLi.Show();

        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();
            b.Show();
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ruta b = new Ruta();
            b.Show();
        }

        private void programacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Llegada b = new Llegada();
            b.Show();
        }

        private void btnClientes_ButtonClick(object sender, EventArgs e)
        {

        }

        private void registrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            administrador.ShowDialog();
            if (administrador.DialogResult == DialogResult.Yes)
            {

            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 administrador = new Form1();
           
            this.Hide();
            administrador.ShowDialog();
        }

        private void choferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chofer cho = new Chofer();
            cho.ShowDialog();

          
        }
    }
}
