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

            dataGridView1.DataSource = new LRutas().GetAll(checkBox1.Checked);

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Ciudad_De_Origen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Ciudad_De_Destino"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Chofer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Estado"].Visible = false;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_datos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DetalleRuta detalle = new DetalleRuta();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.operacion = (byte)MisConstantes.OPERACION.Insercion;

            DialogResult rpta = detalle.ShowDialog();

            if (rpta == DialogResult.OK)
            {
                mostrar_datos();
            }


            
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            mostrar_datos();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DetalleRuta detalle = new DetalleRuta();

                detalle.StartPosition = FormStartPosition.CenterParent;
                detalle.operacion = (byte)MisConstantes.OPERACION.Modificacion;

                detalle.txtID.Text = dataGridView1.CurrentRow.Cells["IDRuta"].Value.ToString();
                detalle.txtOrigen.Text = dataGridView1.CurrentRow.Cells["Ciudad_De_Origen"].Value.ToString();
                detalle.txtDestino.Text = dataGridView1.CurrentRow.Cells["Ciudad_De_Destino"].Value.ToString();
                detalle.txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();

                detalle.txtDuracion.Text = dataGridView1.CurrentRow.Cells["Duracion"].Value.ToString();
                detalle.chofer = dataGridView1.CurrentRow.Cells["Chofer"].Value.ToString();

                detalle.dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["Fecha_De_Viaje"].Value.ToString();
                detalle.boxHora.Text = dataGridView1.CurrentRow.Cells["Hora_De_Salida"].Value.ToString();


                detalle.chkEstado.Checked = checkBox1.Checked;



                DialogResult rpta = detalle.ShowDialog();

                if (rpta == DialogResult.OK)
                {
                    mostrar_datos();
                }

            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Program.IDRuta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.Ciudad_De_Origen = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.Ciudad_De_Destino = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Precio =Convert.ToDecimal( dataGridView1.CurrentRow.Cells[3].Value.ToString());           
            Program.Fecha_De_Viaje = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            Program.Hora_De_Salida = dataGridView1.CurrentRow.Cells[7].Value.ToString();


            this.Close();
        }

      
    }
}
