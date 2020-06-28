using ISVSUR.DATA;
using ISVSUR.Entity;
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
    public partial class ReporteVenta : Form
    {
        public ReporteVenta()
        {
            InitializeComponent();
        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {
         

            buscar();

            dataGridView1.MultiSelect = false;
            dataGridView1.RowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = MisConstantes.COLOR_CELDA_FONDO_GRID_ALTER;

            dataGridView1.Columns["Nombres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Apellidos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Ciudad_De_Origen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Ciudad_De_Destino"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Fecha_De_Viaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["fecha_De_Venta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;




          

            
        }


        public void buscar()
        {


            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ListarventaFecha";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Desde", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Hasta", dateTimePicker2.Value.Date);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<EDetalleVentas>();

                while (reader.Read())
                {
                    
                    lista.Add(new EDetalleVentas
                    {

                        IDVenta = Convert.ToInt32(reader["IDVenta"]),
                        Nombres = (reader["NombresCLie"].ToString()),
                        Apellidos = (reader["ApellidosCLie"].ToString()),
                        DNI = (reader["DNICLie"].ToString()),
                        Ciudad_De_Origen = (reader["CiudadOrigen"].ToString()),
                        Ciudad_De_Destino = (reader["CiudadDestino"].ToString()),
                        Fecha_De_Viaje = Convert.ToDateTime(reader["FechaViaje"].ToString()),
                        Hora_De_Salida = (reader["HoraSalida"].ToString()),
                        precio = Convert.ToDecimal(reader["Precio"].ToString()),
                        Asiento =Convert.ToInt32 (reader["NumAsiento"].ToString()),
                        LugarAsiento = (reader["lugarAsiento"].ToString()),
                        Vendedor = (reader["nombreAdmin"].ToString()),
                        Fecha_De_Venta = Convert.ToDateTime(reader["FechaVenta"].ToString()),


                    });

                }


                dataGridView1.DataSource = lista;


            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
