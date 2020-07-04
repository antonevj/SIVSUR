using ISVSUR.Contract;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVSUR.DATA
{
    public class DChofer : IChofer
    {
       
        public EChofer Get(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EChofer> GetAll(bool status)
        {
            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Chofer_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", status);
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
                        placa = (reader["PlacaBus"].ToString()),



                    });

                }


                return lista;


            }

        }

        public int Create(EChofer t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
             //   EBus d = new EBus();
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_agregar_chofer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombresCho", t.Nombre_completo);          
                cmd.Parameters.AddWithValue("@DNICh", t.DNI);
                cmd.Parameters.AddWithValue("@EdadCho", t.Edad);
                cmd.Parameters.AddWithValue("@SexoChof", t.Sexo);
                cmd.Parameters.AddWithValue("@IDBus", t.placa);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }

        }


        public int Update(EChofer t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_modificar_chofer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDChofer", t.ID);
                cmd.Parameters.AddWithValue("@NombresCho", t.Nombre_completo);
                cmd.Parameters.AddWithValue("@DNICh", t.DNI);
                cmd.Parameters.AddWithValue("@EdadCho", t.Edad);
                cmd.Parameters.AddWithValue("@SexoChof", t.Sexo);
                cmd.Parameters.AddWithValue ("@IDBus", t.placa).ToString();
                cmd.Parameters.AddWithValue("@Estado",t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }


        public int Delete(int IDChofer)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_eliminar_chofer";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDChofer", IDChofer );

                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }


        public IEnumerable<EChofer> Buscar(String DNI, bool Estado)
        {


            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_buscarDNIChofer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNICh", DNI);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<EChofer>();
                while (reader.Read())
                {
                    lista.Add(new EChofer
                    {
                        ID = Convert.ToInt32(reader["IDChofer"]),
                        Nombre_completo = reader["NombresCho"].ToString(),                    
                        DNI = reader["DNICh"].ToString(),
                        Edad = Convert.ToInt32(reader["EdadCho"].ToString()),
                        Sexo = (reader["SexoChof"].ToString()),
                        placa  = reader["PlacaBus"].ToString(),
                       

                    });

                }
                return lista;
            }


        }











    }
}
