﻿using ISVSUR.DATA;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.UI
{
    public partial class General : Form
    {
       
        string id, nombres;
        private ClientesIU _fromCliente;
        private Bus _fromBus;
        private Chofer _fromChofer;
        private Ruta _fromRuta;
        private Administrador _fromadmin;
        private ReporteVenta _fromventa;
       
        
        public General(string id,string nombres)

        {
            InitializeComponent();
            this.id = id;
            this.nombres = nombres;
        }

       


        private void General_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            Form1 fm = new Form1();

            tpID.Text = id;
            tpNombre.Text ="Nombre del usuario: "+ nombres;

            if (tpID.Text=="2")
            {
                tpCargo.Text ="Cargo: "+ "Administrador";
            }
            else
            {
                    tpCargo.Text= "Cargo: " + "Recepcionista";
            }


            if (tpID.Text!="2")
            {
                administradorToolStripMenuItem.Enabled = false;
                btnAdmin.Enabled = false;
                btnCliente.Enabled = false;
                btnChofer.Enabled = false;
                btnBuses.Enabled = false;
                btnRuta.Enabled = false;
                mantenimientoToolStripMenuItem.Enabled = false;
            }
            else
            {
                administradorToolStripMenuItem.Enabled = true;
                btnAdmin.Enabled = true;
                btnCliente.Enabled = true;
                btnChofer.Enabled = true;  
                btnBuses.Enabled = true;     
                btnRuta.Enabled = true;
                mantenimientoToolStripMenuItem.Enabled = true;
            }
        }
       

        

        

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCliente_Click(sender, e);
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           btnAdmin_Click_1(sender, e);
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void choferesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChofer_Click(sender, e);
        }

        private void busToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnBuses_Click(sender, e);
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRuta_Click(sender, e);
        }

        private void programacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void ventasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Formulario_de_Venta b = new Formulario_de_Venta(id);
            b.ShowDialog();
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
            pictureBox1.Visible = false;
        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            if (_fromChofer == null || _fromChofer.IsDisposed == true)
            {
                _fromChofer = new Chofer();
                _fromChofer.WindowState = FormWindowState.Maximized;
                _fromChofer.MdiParent = this;
                _fromChofer.Show();
            }
            else
            {
                _fromChofer.BringToFront();
            }
            pictureBox1.Visible = false;
        }

        private void btnBuses_Click(object sender, EventArgs e)
        {
            if (_fromBus == null || _fromBus.IsDisposed == true)
            {
                _fromBus = new Bus();
                _fromBus.WindowState = FormWindowState.Maximized;
                _fromBus.MdiParent = this;
                _fromBus.Show();
            }
            else
            {
                _fromBus.BringToFront();
            }
            pictureBox1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tpReloj.Text = DateTime.Now.ToString("hh:mm:ss");
            tpFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            if (_fromRuta == null || _fromRuta.IsDisposed == true)
            {
                _fromRuta = new Ruta();
                _fromRuta.WindowState = FormWindowState.Maximized;
                _fromRuta.MdiParent = this;
                _fromRuta.Show();
            }
            else
            {
                _fromRuta.BringToFront();
            }
            pictureBox1.Visible = false;
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            if (_fromadmin == null || _fromadmin.IsDisposed == true)
            {
                _fromadmin = new Administrador();
                _fromadmin.WindowState = FormWindowState.Maximized;
                _fromadmin.MdiParent = this;
                _fromadmin.Show();
            }
            else
            {
                _fromadmin.BringToFront();
            }
            pictureBox1.Visible = false;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 administrador = new Form1();
            this.Hide();
            administrador.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fromventa == null || _fromventa.IsDisposed == true)
            {
                _fromventa = new ReporteVenta();
                _fromventa.WindowState = FormWindowState.Maximized;
                _fromventa.MdiParent = this;
                _fromventa.Show();
            }
            else
            {
                _fromventa.BringToFront();
            }
            pictureBox1.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Formulario_de_Venta b = new Formulario_de_Venta(id);
            b.ShowDialog();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {


            pictureBox1.Visible = true;


        }

    }

    
}
