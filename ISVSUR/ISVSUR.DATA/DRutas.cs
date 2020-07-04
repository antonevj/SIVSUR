using ISVSUR.Contract;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace ISVSUR.DATA
{




    public class DRutas : IRutas
    {

        public ERutas Get(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ERutas> GetAll(bool status)
        {
            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ruta_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Estado",status);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<ERutas>();

                while (reader.Read())
                {

                    lista.Add(new ERutas
                    {

                        IDRuta = Convert.ToInt32(reader["IDRuta"]),
                        Ciudad_De_Origen = (reader["CiudadOrigen"].ToString()),
                        Ciudad_De_Destino = (reader["CiudadDestino"].ToString()),
                        precio = Convert.ToDecimal(reader["Precio"].ToString()),
                        Duracion = (reader["Duracion"].ToString()),
                        Chofer = (reader["NombresCho"].ToString()),
                        Fecha_De_Viaje = Convert.ToDateTime(reader["FechaViaje"].ToString()),
                        Hora_De_Salida = (reader["HoraSalida"].ToString()),

                    });

                }


                return lista;


            }

        }

        public int Create(ERutas t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                //   EBus d = new EBus();
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_agregar_ruta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CiudadOrigen", t.Ciudad_De_Origen);
                cmd.Parameters.AddWithValue("@CiudadDestino", t.Ciudad_De_Destino);
                cmd.Parameters.AddWithValue("@Precio", t.precio);
                cmd.Parameters.AddWithValue("@Duracion", t.Duracion);
                cmd.Parameters.AddWithValue("@IDChofer", t.Chofer);
                cmd.Parameters.AddWithValue("@FechaViaje", t.Fecha_De_Viaje);
                cmd.Parameters.AddWithValue("@HoraSalida", t.Hora_De_Salida);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }

        
       

        public int Update(ERutas t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                //   EBus d = new EBus();
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_modificar_ruta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDRuta", t.IDRuta);
                cmd.Parameters.AddWithValue("@CiudadOrigen", t.Ciudad_De_Origen);
                cmd.Parameters.AddWithValue("@CiudadDestino", t.Ciudad_De_Destino);
                cmd.Parameters.AddWithValue("@Precio", t.precio);
                cmd.Parameters.AddWithValue("@Duracion", t.Duracion);
                cmd.Parameters.AddWithValue("@IDChofer", t.Chofer);
                cmd.Parameters.AddWithValue("@FechaViaje", t.Fecha_De_Viaje);
                cmd.Parameters.AddWithValue("@HoraSalida", t.Hora_De_Salida);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }

        public int Delete(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ERutas> Buscar(string Destino, bool status)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_ruta_Buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Destino", Destino);              
                cmd.Parameters.AddWithValue("@Estado", status);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<ERutas>();
                while (reader.Read())
                {
                    lista.Add(new ERutas
                    {
                        IDRuta = Convert.ToInt32(reader["IDRuta"]),
                        Ciudad_De_Origen = (reader["CiudadOrigen"].ToString()),
                        Ciudad_De_Destino = (reader["CiudadDestino"].ToString()),
                        precio = Convert.ToDecimal(reader["Precio"].ToString()),
                        Duracion = (reader["Duracion"].ToString()),
                        Chofer = (reader["chofer"].ToString()),
                        Fecha_De_Viaje = Convert.ToDateTime(reader["FechaViaje"].ToString()),
                        Hora_De_Salida = (reader["HoraSalida"].ToString()),


                    });

                }
                return lista;
            }
        }
    }
}
