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
                //  cmd.Parameters.AddWithValue();
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
                        Duracion = Convert.ToDateTime(reader["Duracion"].ToString()),
                        Chofer = (reader["NombresCho"].ToString()),

                    });

                }


                return lista;


            }

        }

        public int Create(ERutas t)
        {
            throw new NotImplementedException();
        }

        
       

        public int Update(ERutas t)
        {
            throw new NotImplementedException();
        }

        public int Delete(int IDCliente)
        {
            throw new NotImplementedException();
        }

    }
}
