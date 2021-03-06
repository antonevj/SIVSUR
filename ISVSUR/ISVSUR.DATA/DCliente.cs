﻿using System;
using System.Collections.Generic;

using ISVSUR.Entity;
using System.Data;
using System.Data.SqlClient;
using ISVSUR.Contract;
using System.Windows.Forms;

namespace ISVSUR.DATA
{
    public class DCliente :ICliente
    {
        

        public ECliente Get(int IDCliente)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<ECliente> GetAll(bool status)
        {

            using (SqlConnection cnx = new SqlConnection())
            {

                cnx.ConnectionString = MiCadena.CadenaCnx();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Clientes_getAll";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Estado", status);
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

        public int Create(ECliente t)
        {

            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_agregar_clientes";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombresCli", t.Nombres);
                cmd.Parameters.AddWithValue("@ApellidosClie", t.Apellidos);
                cmd.Parameters.AddWithValue("@DNIClie", t.DNI);
                cmd.Parameters.AddWithValue("@EdadClie", t.Edad);
                cmd.Parameters.AddWithValue("@SexoClie", t.Sexo);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }


        }

        public int Update(ECliente t)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_modificar_clientes";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDCliente", t.IDCliente);
                cmd.Parameters.AddWithValue("@NombresClie", t.Nombres);
                cmd.Parameters.AddWithValue("@ApellidosClie", t.Apellidos);
                cmd.Parameters.AddWithValue("@DNIClie", t.DNI);
                cmd.Parameters.AddWithValue("@EdadClie", t.Edad);
                cmd.Parameters.AddWithValue("@SexoClie", t.Sexo);
                cmd.Parameters.AddWithValue("@Estado", t.Estado);
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }


        public int Delete(int IDCliente)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_eliminar_clientes";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
               
                cmd.Connection = cnx;
                cnx.Open();


                int filasafectadas = cmd.ExecuteNonQuery();

                return filasafectadas;
            }
        }


        public IEnumerable<ECliente> Buscar(String DNI,bool Estado)
        {


            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_buscarporDNI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DNICLie", DNI);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<ECliente>();
                while (reader.Read())
                {
                    lista.Add(new ECliente
                    {
                        IDCliente = Convert.ToInt32(reader["IDCliente"]),
                        Apellidos = reader["ApellidosClie"].ToString(),
                        Nombres = reader["NombresClie"].ToString(),
                        DNI = reader["DNIClie"].ToString(),                      
                        Edad =Convert.ToInt32( reader["EdadClie"].ToString()),
                        Sexo = (reader["SexoClie"].ToString()),

                    });

                }
                return lista;
            }


        }




        public IEnumerable<ECliente> Search(int campo, string valor, bool status)
        {
            using (SqlConnection cnx = new SqlConnection())
            {
                cnx.ConnectionString = MiCadena.CadenaCnx();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "sp_Cliente_Search";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@campo", campo);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@Estado", status);
                cmd.Connection = cnx;
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                var lista = new List<ECliente>();
                while (reader.Read())
                {
                    lista.Add(new ECliente
                    {
                        IDCliente = Convert.ToInt32(reader["IDCliente"]),
                        Apellidos = reader["ApellidosClie"].ToString(),
                        Nombres = reader["NombresClie"].ToString(),
                        DNI = reader["DNIClie"].ToString(),
                        Edad =Convert.ToInt32( reader["EdadClie"].ToString()),
                        Sexo = reader["SexoClie"].ToString(),
                       

                    });

                }
                return lista;
            }
        }
    }
}
