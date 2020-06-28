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
    public class DVentas : IVentas
    {
        public int Create(EVentas t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
              
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_agregar_ventageneral";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCliente", t.IDCliente);
                cmd.Parameters.AddWithValue("@IDRuta", t.IDRuta);
                cmd.Parameters.AddWithValue("@IDAdmin", t.IDAdmin);              
                cmd.Parameters.AddWithValue("@Asiento", t.Asiento);
                cmd.Parameters.AddWithValue("@LugarAsiento", t.LugarAsiento);
                cmd.Parameters.AddWithValue("@FechaVenta", t.Fecha_De_Venta);
                cmd.Parameters.AddWithValue("@Reservado", t.Reservado);

                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();



                return filasafectadas;


            }

        }

        public EVentas Get(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EVentas> GetAll(bool Reservado)
        {
            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_venta_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Reservado", Reservado);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<EVentas>();

                while (reader.Read())
                {

                    lista.Add(new EVentas
                    {
                        IDVenta = Convert.ToInt32(reader["IDVenta"]),
                        Asiento = Convert.ToInt32(reader["NumAsiento"]),
                       
                       

                    });

                }


                return lista;


            }

        
    }
    }
}
