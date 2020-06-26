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
                //   EBus d = new EBus();
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

                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();



                return filasafectadas;


            }

        }

      
    }
}
