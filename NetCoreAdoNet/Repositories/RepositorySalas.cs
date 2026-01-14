using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
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

        private async Task OpenConnAsync()
        {
            await conn.OpenAsync();
        }

        private async Task CloseConnAsync()
        {
            await conn.CloseAsync(); 
        }

        private async Task CloseReaderAsync()
        {
            await reader.CloseAsync();
        }

        private async Task IniciarCommandAsync(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
        }

        public async Task<List<string>> GetNombreSalasAsync()
        {
            List<string> salas = new List<string>();

            await IniciarCommandAsync("select distinct NOMBRE from SALA");
            await OpenConnAsync();

            reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                salas.Add(reader["NOMBRE"].ToString());
            }

            await CloseConnAsync();
            await CloseReaderAsync();

            return salas;
        }

        public async Task<int> UpdateSalaAsync(string nuevo, string viejo)
        {
            int registros;

            await IniciarCommandAsync("update SALA set NOMBRE=@nuevo where NOMBRE=@VIEJO");

            SqlParameter paramNuevo = new SqlParameter("@nuevo", nuevo);
            SqlParameter paramViejo = new SqlParameter("@viejo", viejo);
            command.Parameters.Add(paramNuevo);
            command.Parameters.Add(paramViejo);

            await OpenConnAsync();
            registros = await command.ExecuteNonQueryAsync();
            await CloseConnAsync();

            command.Parameters.Clear();

            return registros;
        }
    }
}
