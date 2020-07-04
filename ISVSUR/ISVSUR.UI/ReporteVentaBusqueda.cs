using ISVSUR.Logic;
using ISVSUR.Util;
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
    public partial class ReporteVentaBusqueda : Form
    {
        public ReporteVentaBusqueda()
        {
            InitializeComponent();
        }

        private void ReporteVentaBusqueda_Load(object sender, EventArgs e)
        {

            cboBuscador.Items.Add("Tipo de documento");
            cboBuscador.Items.Add("Ciudad de destino");
            cboBuscador.Items.Add("Hora de salida");
        }

        private void MostrarDatos()
        {

            //dataGridView1.Columns["Apellidos"].HeaderText = "Apellidos";
           // dataGridView1.Columns["Apellidos"].DataPropertyName = "Apellidos";
            dataGridView1.Columns["apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // dataGridView1.Columns["Apellidos"].ReadOnly = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
           
            dataGridView1.Columns["IDCliente"].Visible = false;
            dataGridView1.Columns["IDRuta"].Visible = false;
            dataGridView1.Columns["IDAdmin"].Visible = false;
            dataGridView1.Columns["Reservado"].Visible = false;
           
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LVentas().Search(cboBuscador.SelectedIndex, txtValor.Text, checkBox1.Checked);
            MostrarDatos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
