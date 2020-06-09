using ISVSUR.Contract;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISVSUR.DATA
{
    public class DChofer : IChofer
    {
        public EChofer Get(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EChofer> GetAll()
        {
            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Chofer_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                //  cmd.Parameters.AddWithValue();
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<EChofer>();

                while (reader.Read())
                {

                    lista.Add(new EChofer
                    {

                        ID = Convert.ToInt32(reader["IDChofer"]),
                        Nombre_completo = (reader["NombresCho"].ToString()),                      
                        DNI = (reader["DNICh"].ToString()),
                        Edad = Convert.ToInt32(reader["EdadCho"]),
                        Sexo = (reader["SexoChof"].ToString()),
                        Placa = (reader["PlacaBus"].ToString()),



                    });

                }


                return lista;


            }

        }
    }
}
