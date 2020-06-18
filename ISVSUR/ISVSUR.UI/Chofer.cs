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
    public partial class Chofer : Form
    {
        public Chofer()
        {
            InitializeComponent();
        }


        private void Chofer_Load(object sender, EventArgs e)
        {
            mostrar_datos();
        }


        private void mostrar_datos()
        {

            dataGridView1.DataSource = new LChofer().GetAll(checkBox1.Checked);

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Nombre_completo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Estado"].Visible = false;


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            DetalleChofer detalle = new DetalleChofer();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.operacion = (byte)MisConstantes.OPERACION.Insercion;

            DialogResult rpta = detalle.ShowDialog();

            if (rpta == DialogResult.OK)
            {
                mostrar_datos();
            }


            DetalleChofer fmr = new DetalleChofer();
            fmr.Show();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DetalleChofer detalle = new DetalleChofer();

                detalle.StartPosition = FormStartPosition.CenterParent;
                detalle.operacion = (byte)MisConstantes.OPERACION.Modificacion;

                detalle.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                detalle.txtNombres.Text = dataGridView1.CurrentRow.Cells["Nombre_completo"].Value.ToString();
                detalle.txtDNI.Text = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                detalle.txtEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                detalle.boxSexo.Text = dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString();
                detalle.boxBus.Text = dataGridView1.CurrentRow.Cells["Placa"].Value.ToString();
                detalle.chkEstado.Checked = checkBox1.Checked;

                DialogResult rpta = detalle.ShowDialog();

                if (rpta == DialogResult.OK)
                {
                    mostrar_datos();
                }

            }
        }

        private void btnElimina(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                DialogResult k = MessageBox.Show("Estas seguro  de eliminar este registro?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                int rpta = 0;

                if (k == DialogResult.Yes)
                {
                    //capturar la fila del id para poder eliminar
                    int IDChofer = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

                    rpta = new LChofer().Delete(IDChofer);

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var aux = new LChofer();
            aux.Buscar(dataGridView1, this.textBox1.Text.Trim());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_datos();
        }
    }
}
