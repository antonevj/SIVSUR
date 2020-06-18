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
    public class DBus : IBus
    {
        public EBus Get(int IDBus)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EBus> GetAll(bool status)
        {

            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Bus_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", status);
                //  cmd.Parameters.AddWithValue();
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<EBus>();

                while (reader.Read())
                {

                    lista.Add(new EBus
                    {

                        ID = Convert.ToInt32(reader["IDBus"]),
                        Modelo = (reader["ModeloBus"].ToString()),
                        Placa = (reader["PlacaBus"].ToString()),
                        Capacidad = (reader["CapacidadBus"].ToString()),

                    });

                }


                return lista;


            }

        }

        public int Create(EBus t)
        {

            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_agregar_Bus";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ModeloBus", t.Modelo);
                cmd.Parameters.AddWithValue("@PlacaBus", t.Placa);
                cmd.Parameters.AddWithValue("@CapacidadBus", t.Capacidad);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }

        public int Update(EBus t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_modificar_Bus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDBus", t.ID);
                cmd.Parameters.AddWithValue("@ModeloBus", t.Modelo);
                cmd.Parameters.AddWithValue("@PlacaBus", t.Placa);
                cmd.Parameters.AddWithValue("@CapacidadBus", t.Capacidad);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }

        public int Delete(int IDBus)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_eliminar_Bus";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDBus", IDBus);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }

        public void Buscar(DataGridView data, string PlacaBus)
        {


            try
            {
                SqlConnection cnx = new SqlConnection(MiCadena.CadenaCnx());
                SqlCommand cmd = new SqlCommand("sp_buscarporPlaca", cnx);
                //    cmd.CommandText = "sp_buscarporPlaca";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlacaBus", PlacaBus);
                cmd.Connection = cnx;
                cnx.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                data.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }




        }
    }
}
