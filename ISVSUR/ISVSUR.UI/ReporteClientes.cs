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
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LCliente().Search(cboBuscador.SelectedIndex, txtValor.Text, checkBox1.Checked);
            MostrarDatos();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {

            cboBuscador.Items.Add("Tipo de documento");
            cboBuscador.Items.Add("Nombres");
            cboBuscador.Items.Add("Apellidos");




        }


        private void MostrarDatos()
        {

            dataGridView1.Columns["Apellidos"].HeaderText = "Apellidos";
            dataGridView1.Columns["Apellidos"].DataPropertyName = "Apellidos";
            dataGridView1.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Apellidos"].ReadOnly = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns["Estado"].Visible = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cboBuscador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
