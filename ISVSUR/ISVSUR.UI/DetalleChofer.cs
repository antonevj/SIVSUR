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
using ISVSUR.DATA;

using System.Data.SqlClient;
namespace ISVSUR.UI
{
    public partial class DetalleChofer : Form
    {

        public byte operacion { get; set; }

   

        public DetalleChofer()
        {
          InitializeComponent();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DetalleChofer_Load(object sender, EventArgs e)
        {
            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {

            }

            if (operacion == (byte)MisConstantes.OPERACION.Modificacion)
            {

            }
            llenarplaca();



        }


        public void llenarplaca( )
        {

            SqlConnection cnx = new SqlConnection(MiCadena.CadenaCnx());
            cnx.Open();

            string query = "select IDBus,PlacaBus from bus";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();
           
            List<LlenarBus> lista = new List<LlenarBus>();

            while (dr.Read())
            {
                lista.Add(new LlenarBus
                {
                    IDBus = Convert.ToInt32(dr["IDBus"]),
                    PlacaBus = Convert.ToString(dr["PlacaBus"]),

                });
            }

            cnx.Close();
    
            //llenamos el combo
            boxBus.DisplayMember = "PlacaBus";
            boxBus.ValueMember = "IDBus";
            boxBus.DataSource = lista;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EChofer obj = new EChofer
            {

                ID = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Nombre_completo = txtNombres.Text.Trim().ToUpper(),             
                DNI = txtDNI.Text,
                Edad = int.Parse(txtEdad.Text),
                Sexo = boxSexo.Text,
                placa= ( lblIDBus.Text)



            };

            int rpta;

            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LChofer().Create(obj);

            }
            else
            {
                rpta = new LChofer().Update(obj);
            }

            if (rpta > 0)
            {

                MessageBox.Show("operacion realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void boxBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxBus.SelectedIndex > -1)
            {
                lblIDBus.Text = boxBus.SelectedValue.ToString();
            }
        }
    }
}
