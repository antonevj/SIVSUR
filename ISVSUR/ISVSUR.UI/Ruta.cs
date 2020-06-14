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
    public partial class Ruta : Form
    {
        public Ruta()
        {
            InitializeComponent();
        }

        

        private void Ruta_Load(object sender, EventArgs e)
        {
            mostrar_datos();
        }

        private void mostrar_datos()
        {

            dataGridView1.DataSource = new LRutas().GetAll();

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Ciudad_De_Origen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Ciudad_De_Destino"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DetalleRuta fmr = new DetalleRuta();
            fmr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
