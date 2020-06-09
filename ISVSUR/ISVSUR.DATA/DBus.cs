using ISVSUR.Contract;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ISVSUR.DATA
{
    public class DBus : IBus
    {
        public EBus Get(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EBus> GetAll()
        {

            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Bus_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
