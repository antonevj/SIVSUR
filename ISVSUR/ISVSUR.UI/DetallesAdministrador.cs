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
    public partial class DetallesAdministrador : Form
    {

        public byte operacion { get; set; }
        public DetallesAdministrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EAdmin obj = new EAdmin
            {

                ID = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Nombres = txtNombres.Text.Trim().ToUpper(),
                Apellidos = txtApellidos.Text.Trim().ToUpper(),
                Usuario = txtUsuario.Text.Trim().ToUpper(),
                Contraseña = txtContra.Text.Trim().ToUpper()

            };

            int rpta = 0;
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LAdmin().Create(obj);

            }
            else
            {
                rpta = new LAdmin().Update(obj);
            }

            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
