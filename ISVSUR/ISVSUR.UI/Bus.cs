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
    public partial class Bus : Form
    {
        public Bus()
        {
            InitializeComponent();
        }

      

        private void Bus_Load(object sender, EventArgs e)
        {

            mostrar_datos();
        }
        private void mostrar_datos()
        {

            var a = dataGridView1.DataSource = new LBus().GetAll(checkBox1.Checked);

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Modelo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Estado"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            DetalleBus detalle = new DetalleBus();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.operacion = (byte)MisConstantes.OPERACION.Insercion;

            DialogResult rpta = detalle.ShowDialog();

            if (rpta == DialogResult.OK)
            {
                mostrar_datos();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DetalleBus detalle = new DetalleBus();

                detalle.StartPosition = FormStartPosition.CenterParent;
                detalle.operacion = (byte)MisConstantes.OPERACION.Modificacion;

                detalle.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                detalle.txtModelo.Text = dataGridView1.CurrentRow.Cells["Modelo"].Value.ToString();
                detalle.txtPlaca.Text = dataGridView1.CurrentRow.Cells["Placa"].Value.ToString();
                detalle.txtCapacidad.Text = dataGridView1.CurrentRow.Cells["Capacidad"].Value.ToString();
                detalle.chkEstado.Checked = checkBox1.Checked;

                DialogResult rpta = detalle.ShowDialog();

                if (rpta == DialogResult.OK)
                {
                    mostrar_datos();
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                DialogResult k = MessageBox.Show("Estas seguro  de eliminar este registro?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                int rpta = 0;

                if (k == DialogResult.Yes)
                {
                    //capturar la fila del id para poder eliminar
                    int ID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

                    rpta = new LBus().Delete(ID);

                    if (rpta > 0)
                    {
                        MessageBox.Show("datos eliminados correctamente", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mostrar_datos();
                    }

                }
            }
            else

                MessageBox.Show("debe seleccionar un elemento");
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            var aux = new LBus();
            aux.Buscar(dataGridView1, this.txtPlaca.Text.Trim());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_datos();
        }
    }
}
