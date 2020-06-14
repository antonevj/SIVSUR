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
      
        public EAdmin Get(int IDAdmin)
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

        public int Create(EAdmin t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_agregar_administrador";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreAdmin", t.Nombres);
                cmd.Parameters.AddWithValue("@ApellidoAdmin", t.Apellidos);
                cmd.Parameters.AddWithValue("@UsuarioAdmin", t.Usuario);
                cmd.Parameters.AddWithValue("@ContraseniaAdmin", t.Contraseña);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }


        public int Update(EAdmin t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_modificar_administrador";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDAdmin", t.ID);
                cmd.Parameters.AddWithValue("@NombreAdmin", t.Nombres);
                cmd.Parameters.AddWithValue("@ApellidoAdmin", t.Apellidos);
                cmd.Parameters.AddWithValue("@UsuarioAdmin", t.Usuario);
                cmd.Parameters.AddWithValue("@ContraseniaAdmin", t.Contraseña);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }


        public int Delete(int IDAdmin)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_eliminar_Administrador";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDAdmin", IDAdmin);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }

    }
}
