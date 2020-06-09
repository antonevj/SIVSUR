using ISVSUR.Contract;
using ISVSUR.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ISVSUR.DATA
{
    public class DAdmin : IAdmin
    {
        public EAdmin Get(int IDCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EAdmin> GetAll()
        {




            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Administrador_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                //  cmd.Parameters.AddWithValue();
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<EAdmin>();

                while (reader.Read())
                {

                    lista.Add(new EAdmin
                    {

                        ID = Convert.ToInt32(reader["IDAdmin"]),
                        Nombres = (reader["NombreAdmin"].ToString()),
                        Apellidos = (reader["ApellidoAdmin"].ToString()),
                        Usuario = (reader["UsuarioAdmin"].ToString()),
                        Contraseña = (reader["ContraseniaAdmin"].ToString()),





                    });

                }


                return lista;


            }



        }
    }
}
