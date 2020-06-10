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

          var a =  dataGridView1.DataSource = new LCliente().GetAll();

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
       

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
         

         
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void btnBuscarCLiente_Click(object sender, EventArgs e)
        {
           
           

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var aux = new LCliente();
            aux.Buscar(dataGridView1, this.textBox1.Text.Trim());
        }
    }
}
