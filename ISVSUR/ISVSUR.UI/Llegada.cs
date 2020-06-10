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
    public partial class Llegada : Form
    {
        public Llegada()
        {
            InitializeComponent();
        }

        private void Llegada_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DetalleLlegada fmr = new DetalleLlegada();
            fmr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
