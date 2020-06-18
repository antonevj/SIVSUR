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
    public partial class DetallesClienteIU : Form
    {

        public byte operacion { get; set; }

        public DetallesClienteIU()
        {
            InitializeComponent();
        }

        private void DetallesClienteIU_Load(object sender, EventArgs e)
        {
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
              
            }

            if (operacion == (byte)MisConstantes.OPERACION.Modificacion)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool MyValidation()
        {
            bool rpta = false;

            //arrary que almacena la coleccion de errores
            bool[] error = new bool[3];


            ///validamos el campo nombre 
            if (String.IsNullOrWhiteSpace(txtNombres.Text))
            {
                errorProvider1.SetError(txtNombres, "El nombre es obligatorio");
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
            private void button1_Click(object sender, EventArgs e)
        {


            if (!MyValidation())
            {


                return;

            }
            ECliente obj = new ECliente
            {

                IDCliente = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Nombres = txtNombres.Text.Trim().ToUpper(),
                Apellidos = txtApellidos.Text.Trim().ToUpper(),
                DNI = txtDNI.Text,
                Edad = int.Parse(txtEdad.Text),
                Sexo = boxSexo.Text,
                Estado=chkEstado.Checked


            };

            int rpta = 0;
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LCliente().Create(obj);

            }
            else
            {
                rpta = new LCliente().Update(obj);
            }

            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("llene los datos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
