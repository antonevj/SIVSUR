using ISVSUR.DATA;
using ISVSUR.Entity;
using ISVSUR.Logic;
using ISVSUR.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.UI
{
    public partial class DetalleRuta : Form
    {
        public byte operacion { get; set; }
        public string chofer { get; set; }
        public DetalleRuta()
        {
            InitializeComponent();
        }

        private void DetalleRuta_Load(object sender, EventArgs e)
        {
            llenarChofer();
            boxChofer.Text = chofer;

        }


        public void llenarChofer()
        {

            SqlConnection cnx = new SqlConnection(MiCadena.CadenaCnx());
            cnx.Open();

            //string query = "select IDBus,PlacaBus from bus where Estado=1";
            SqlCommand cmd = new SqlCommand("sp_llenar_Chofer", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            //  SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            // cmd.CommandText = query;
            SqlDataReader dr = cmd.ExecuteReader();

            List<LlenarChofer> lista = new List<LlenarChofer>();

            while (dr.Read())
            {
                lista.Add(new LlenarChofer
                {
                    IDChofer = Convert.ToInt32(dr["IDChofer"]),
                    NombresCho = Convert.ToString(dr["NombresCho"]),

                });
            }

            cnx.Close();

            //llenamos el combo
            boxChofer.DisplayMember = "NombresCho";
            boxChofer.ValueMember = "IDChofer";
            boxChofer.DataSource = lista;


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



        private bool MyValidation()
        {
            bool rpta = false;

            //arrary que almacena la coleccion de errores
            bool[] error = new bool[3];


            ///validamos el campo nombre 
            if (String.IsNullOrWhiteSpace(txtOrigen.Text))
            {
                errorProvider1.SetError(txtOrigen, "El origen es obligatorio");
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

            ERutas obj = new ERutas
            {

                IDRuta = txtID.Text.Length == 0 ? 0 : int.Parse(txtID.Text),
                Ciudad_De_Origen = txtOrigen.Text.Trim().ToUpper(),
                Ciudad_De_Destino = txtDestino.Text.Trim().ToUpper(),
                precio = Convert.ToDecimal(txtPrecio.Text),
                Duracion = (txtDuracion.Text),
                Chofer = (lblIDChofer.Text),
                Fecha_De_Viaje =Convert.ToDateTime( dateTimePicker2.Text),
                Hora_De_Salida=boxHora.Text,
                Estado = chkEstado.Checked,
              

            };

            int rpta;

            if (operacion == (byte)MisConstantes.OPERACION.Insercion)
            {
                rpta = new LRutas().Create(obj);

            }
            else
            {
                rpta = new LRutas().Update(obj);
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

        private void boxChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxChofer.SelectedIndex > -1)
            {
                lblIDChofer.Text = boxChofer.SelectedValue.ToString();
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblIDChofer_Click(object sender, EventArgs e)
        {

        }

        private void boxHora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
