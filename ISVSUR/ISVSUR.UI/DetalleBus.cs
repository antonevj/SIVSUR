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

        private void Button1_Click(object sender, EventArgs e)
        {
            EBus obj = new EBus
            {

                ID = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Modelo = txtModelo.Text.Trim().ToUpper(),
                Placa = txtPlaca.Text.Trim().ToUpper(),
                Capacidad = txtCapacidad.Text,

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
    }
}

