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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            mostrar_datos();
        }

        private void mostrar_datos()
        {

            var a = dataGridView1.DataSource = new LAdmin().GetAll();

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DetallesAdministrador detalle = new DetallesAdministrador();
            detalle.StartPosition = FormStartPosition.CenterScreen;
            detalle.operacion = (byte)MisConstantes.OPERACION.Insercion;

            DialogResult rpta = detalle.ShowDialog();

            if (rpta == DialogResult.OK)
            {
                mostrar_datos();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DetallesAdministrador detalle = new DetallesAdministrador();

                detalle.StartPosition = FormStartPosition.CenterParent;
                detalle.operacion = (byte)MisConstantes.OPERACION.Modificacion;

                detalle.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                detalle.txtNombres.Text = dataGridView1.CurrentRow.Cells["Nombres"].Value.ToString();
                detalle.txtApellidos.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                detalle.txtUsuario.Text = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
                detalle.txtContra.Text = dataGridView1.CurrentRow.Cells["Contraseña"].Value.ToString();


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

                    rpta = new LAdmin().Delete(ID);

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
    }
}
