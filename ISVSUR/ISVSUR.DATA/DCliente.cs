using System;
using System.Collections.Generic;

using ISVSUR.Entity;
using System.Data;
using System.Data.SqlClient;
using ISVSUR.Contract;


namespace ISVSUR.DATA
{
    public class DCliente :ICliente
    {
        public int Create(ECliente t)
        {

            throw new NotImplementedException();


        }



        public ECliente Get(int IDCliente)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ECliente> GetAll()
        {

            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Clientes_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                //  cmd.Parameters.AddWithValue();
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<ECliente>();

                while (reader.Read())
                {

                    lista.Add(new ECliente
                    {

                        IDCliente = Convert.ToInt32(reader["IDCliente"]),
                        Nombres = (reader["NombresClie"].ToString()),
                        Apellidos= (reader["ApellidosClie"].ToString()),
                        DNI = (reader["DNIClie"].ToString()),
                        Edad = Convert.ToInt32(reader["EdadClie"]),
                        Sexo = (reader["SexoClie"].ToString()),




                    });

                }


                return lista;   


            }

        }
    }
}
