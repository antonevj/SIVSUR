using ISVSUR.DATA;
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
    public partial class Form1 : Form
    {
        string id, nombres,apellidos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            using (SqlConnection cnx = new SqlConnection())
            {
              
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                  
                cmd.CommandText = "sp_login";
                cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@usuario",txtUsuario.Text);
                cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text);
                cmd.Connection = cnx;
                cnx.Open();

                //5.Declarar una variable tipo Reader...
                SqlDataReader LectorDatos;

                //6.Vamos a ejecutar la query a través del objeto comando...
                LectorDatos = cmd.ExecuteReader();
                if (LectorDatos.Read() == true)
                {
                    id = LectorDatos["IDAdmin"].ToString();
                    nombres = LectorDatos["NombreAdmin"].ToString();
                    apellidos = LectorDatos["ApellidoAdmin"].ToString();

                }

              
                //7.Validar si el Lector de Datos tiene registros...
                Boolean ExistenciaRegistros = LectorDatos.HasRows;

                //8.Validamos la entrada del usuario al sistema...

                if (ExistenciaRegistros)
                {
                    MessageBox.Show("Bienvenido al sistema   : " +nombres+" "+apellidos, "acceso autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //cargar el formulario principal de nuestra aplicación

                    General FrmPrincipal = new General(id,nombres,apellidos);
                    //aqui ocultamos el formulario del login...
                    this.Hide();
                    FrmPrincipal.Show();

                    Boleta b = new Boleta( nombres,apellidos);
                   
                }

                else
                {
                    //en el caso de que el usuario no este registrado...

                    MessageBox.Show("Usuario incorrecto" + txtUsuario.Text, "Usuario NO registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //abandonamos el evento...
                    return;

                }

                //9.Cerramos la conexión a la base de datos...
                cnx.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
