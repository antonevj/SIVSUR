using ISVSUR.Entity;
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
    public partial class DetalleBus : Form
    {
        public byte operacion { get; set; }
        public DetalleBus()
        {
            
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private bool MyValidation()
        {
            bool rpta = false;

            //arrary que almacena la coleccion de errores
            bool[] error = new bool[3];


            ///validamos el campo nombre 
            if (String.IsNullOrWhiteSpace(txtModelo.Text))
            {
                errorProvider1.SetError(txtModelo, "El modelo es obligatorio");
                error[0] = true;

            }


            //colocar las demas validaciones
            if (error[0] == true || error[1] == true)
            {
                MessageBox.Show("Error de validación.\n" + "Ingrese los datos en los campos obligatorios o verifique que estos sean válidos",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                rpta = false;
            }
            else
            {
                rpta = true;
            }




            return rpta;
        }















        private void Button1_Click(object sender, EventArgs e)
        {


            if (!MyValidation())
            {


                return;

            }
            EBus obj = new EBus
            {

                ID = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Modelo = txtModelo.Text.Trim().ToUpper(),
                Numero_De_Llantas =int.Parse( txtLlantas.Text.Trim().ToUpper()),
                Chasis = txtChasis.Text.Trim().ToUpper(),
                Año_Fabricaciòn = txtAÑo.Text.Trim().ToUpper(),
                Tipo_Combustible = boxCombustible.Text.Trim().ToUpper(),
                rutina = boxRutina.Text.Trim().ToUpper(),
                Placa = txtPlaca.Text.Trim().ToUpper(),
                Capacidad = txtCapacidad.Text,
                Estado = chkEstado.Checked,

            };

            int rpta = 0;
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LBus().Create(obj);

            }
            else
            {
                rpta = new LBus().Update(obj);
            }

            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtOrigen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDuracion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void boxRutina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

