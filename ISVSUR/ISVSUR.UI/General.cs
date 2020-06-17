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

        private ClientesIU _fromCliente;
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

       

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCliente_Click(sender, e);
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            administrador.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 administrador = new Form1();
            this.Hide();
            administrador.ShowDialog();
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Chofer cho = new Chofer();
            cho.ShowDialog();
        }

        private void busToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bus b = new Bus();
            b.ShowDialog();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ruta b = new Ruta();
            b.ShowDialog();
        }

        private void programacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Llegada b = new Llegada();
            b.ShowDialog();
        }

        private void ventasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Formulario_de_Venta CLi = new Formulario_de_Venta();
            CLi.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (_fromCliente == null || _fromCliente.IsDisposed == true)
            {
                _fromCliente = new ClientesIU();
                _fromCliente.WindowState = FormWindowState.Maximized;
                _fromCliente.MdiParent = this;
                _fromCliente.Show();
            }
            else
            {
                _fromCliente.BringToFront();
            }
        }
    }
}
