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
                        Numero_De_Llantas = Convert.ToInt32(reader["Nllantas"]),
                        Chasis = (reader["chasis"].ToString()),
                        Año_Fabricaciòn = (reader["AñoFabricacion"].ToString()),
                        Tipo_Combustible = (reader["Combustible"].ToString()),
                        rutina = (reader["rutina"].ToString()),
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
                cmd.Parameters.AddWithValue("@Nllantas", t.Numero_De_Llantas);
                cmd.Parameters.AddWithValue("@chasis", t.Chasis);
                cmd.Parameters.AddWithValue("@AñoFabricacion", t.Año_Fabricaciòn);
                cmd.Parameters.AddWithValue("@Combustible", t.Tipo_Combustible);
                cmd.Parameters.AddWithValue("@rutina", t.rutina);
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
                cmd.Parameters.AddWithValue("@Nllantas", t.Numero_De_Llantas);
                cmd.Parameters.AddWithValue("@chasis", t.Chasis);
                cmd.Parameters.AddWithValue("@AñoFabricacion", t.Año_Fabricaciòn);
                cmd.Parameters.AddWithValue("@Combustible", t.Tipo_Combustible);
                cmd.Parameters.AddWithValue("@rutina", t.rutina);
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

      
        public IEnumerable<EBus> BUscarPlaca(string placa,bool status)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_buscarporPlaca";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PlacaBus", placa);
                cmd.Parameters.AddWithValue("@Estado", status);

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
                        Numero_De_Llantas = Convert.ToInt32(reader["Nllantas"]),
                        Chasis = (reader["chasis"].ToString()),
                        Año_Fabricaciòn = (reader["AñoFabricacion"].ToString()),
                        Tipo_Combustible = (reader["Combustible"].ToString()),
                        rutina = (reader["rutina"].ToString()),
                        Placa = (reader["PlacaBus"].ToString()),
                        Capacidad = (reader["CapacidadBus"].ToString()),


                    });

                }
                return lista;
            }
        }
    }
}
