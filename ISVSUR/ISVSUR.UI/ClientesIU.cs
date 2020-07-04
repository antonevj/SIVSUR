using ISVSUR.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISVSUR.Entity;
using ISVSUR.Util;

namespace ISVSUR.UI
{
    public partial class ClientesIU : Form
    {

       
        public ClientesIU()
        {
            InitializeComponent();
        }
       
        private void ClientesIU_Load(object sender, EventArgs e)
        {

    

            mostrar_datos();



        }



        private void mostrar_datos()
        {

            dataGridView1.DataSource = new LCliente().GetAll(checkBox1.Checked);

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

          
            dataGridView1.Columns["Estado"].Visible = false;


            dataGridView1.Columns["Nombres"].HeaderText = "Nombres";
            dataGridView1.Columns["Nombres"].DataPropertyName = "Nombres";
            dataGridView1.Columns["Nombres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Nombres"].ReadOnly = true;

            dataGridView1.Columns["Apellidos"].HeaderText = "Apellidos";
            dataGridView1.Columns["Apellidos"].DataPropertyName = "Apellidos";
            dataGridView1.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Apellidos"].ReadOnly = true;

            dataGridView1.Columns["DNI"].HeaderText = "DNI";
            dataGridView1.Columns["DNI"].DataPropertyName = "DNI";
            dataGridView1.Columns["DNI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["DNI"].ReadOnly = true;

            dataGridView1.Columns["Nombres"].HeaderText = "Nombres";
            dataGridView1.Columns["Nombres"].DataPropertyName = "Nombres";
            dataGridView1.Columns["Nombres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["Nombres"].ReadOnly = true;
        }



     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

       
        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
         

         
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            DetallesClienteIU detalle = new DetallesClienteIU();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.operacion = (byte)MisConstantes.OPERACION.Insercion;

            DialogResult rpta = detalle.ShowDialog();

            if (rpta == DialogResult.OK)
            {
                mostrar_datos();
            }


        }

        private void btnModificar1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DetallesClienteIU detalle = new DetallesClienteIU();

                detalle.StartPosition = FormStartPosition.CenterParent;
                detalle.operacion = (byte)MisConstantes.OPERACION.Modificacion;

                detalle.txtID.Text = dataGridView1.CurrentRow.Cells["IDCliente"].Value.ToString();
                detalle.txtNombres.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                detalle.txtApellidos.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                detalle.txtDNI.Text = dataGridView1.CurrentRow.Cells["DNI"].Value.ToString();
                detalle.txtEdad.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                detalle.boxSexo.Text = dataGridView1.CurrentRow.Cells["Sexo"].Value.ToString();
                detalle.chkEstado.Checked = checkBox1.Checked;


                DialogResult rpta = detalle.ShowDialog();

                if (rpta == DialogResult.OK)
                {
                    mostrar_datos();
                }

            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                DialogResult k = MessageBox.Show("Estas seguro  de eliminar este registro?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                int rpta = 0;

                if (k == DialogResult.Yes)
                {
                    //capturar la fila del id para poder eliminar
                    int IDCliente = (int)dataGridView1.CurrentRow.Cells["IDCliente"].Value;

                    rpta = new LCliente().Delete(IDCliente);

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

      

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Program.IDCliente =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.Nombres = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.Apellidos = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.DNI = (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            Program.edad = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Program.sexo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
           
           


            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LCliente().Buscar(TextBox1.Text, checkBox1.Checked);
            //  mostrar_datos();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            mostrar_datos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
