using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositorySalas
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public RepositorySalas()
        {
            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

            conn = new SqlConnection(stringConn);
            command = new SqlCommand();
        }

        private void OpenConn()
        {
            conn.Open();
        }

        private void CloseConn()
        {
            conn.Close(); 
        }

        private void CloseReader()
        {
            reader.Close();
        }

        private void IniciarCommand(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
        }

        public List<string> GetNombreSalas()
        {
            List<string> salas = new List<string>();

            IniciarCommand("salect distinct NOMBRE from SALA");
            OpenConn();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                salas.Add(reader["NOMBRE"].ToString());
            }

            CloseConn();
            CloseReader();

            return salas;
        }

        public int UpdateSala(string nuevo, string viejo)
        {
            int registros;

            IniciarCommand("update SALA set NOMBRE=@nuevo where NOMBRE=@VIEJO");

            SqlParameter paramNuevo = new SqlParameter("@nuevo", nuevo);
            SqlParameter paramViejo = new SqlParameter("@viejo", viejo);
            command.Parameters.Add(paramNuevo);
            command.Parameters.Add(paramViejo);

            OpenConn();
            registros = command.ExecuteNonQuery();
            CloseConn();

            command.Parameters.Clear();

            return registros;
        }
    }
}
