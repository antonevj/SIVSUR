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
            ECliente obj = new ECliente
            {

                IDCliente = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Nombres = txtNombres.Text.Trim().ToUpper(),
                Apellidos = txtApellidos.Text.Trim().ToUpper(),
                DNI = txtDNI.Text,
                Edad =int.Parse (txtEdad.Text),
                Sexo = boxSexo.Text



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
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
