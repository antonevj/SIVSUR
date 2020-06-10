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

namespace ISVSUR.UI
{
    public partial class Bus : Form
    {
        public Bus()
        {
            InitializeComponent();
        }

      

        private void Bus_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LBus().GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DetalleBus fmr = new DetalleBus();
            fmr.Show();
        }
    }
}
