using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

            conn = new SqlConnection(stringConn);
            command = new SqlCommand();
        }

        private async Task IniciarCommandAsync(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
        }

        public async Task<List<Hospital>> LoadHospitalesAsync()
        {
            List<Hospital> hospitales = new List<Hospital>();

            string sql = "select * from HOSPITAL";
            await IniciarCommandAsync(sql);
            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Hospital hospital = new Hospital();
                hospital.IdHospital = int.Parse(reader["HOSPITAL_COD"].ToString());
                hospital.NombreHospital = reader["NOMBRE"].ToString();
                hospital.DireccionHospital = reader["DIRECCION"].ToString();
                hospital.TelefonoHospital = reader["TELEFONO"].ToString();
                hospital.NumeroCamas = int.Parse(reader["NUM_CAMA"].ToString());

                hospitales.Add(hospital);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();

            return hospitales;
        }
        public async Task<int> InsertHospAsync(Hospital hosp)
        {
            int registros;

            command.Parameters.Clear();

            SqlParameter paramId = new SqlParameter("@id", hosp.IdHospital);
            SqlParameter paramNombre = new SqlParameter("@nombre", hosp.NombreHospital);
            SqlParameter paramDir = new SqlParameter("@dir", hosp.DireccionHospital);
            SqlParameter paramTlf = new SqlParameter("@tlf", hosp.TelefonoHospital);
            SqlParameter paramNumCamas = new SqlParameter("@camas", hosp.NumeroCamas);
            command.Parameters.Add(paramId);
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramDir);
            command.Parameters.Add(paramTlf);
            command.Parameters.Add(paramNumCamas);

            await IniciarCommandAsync("insert into HOSPITAL VALUES (@id, @nombre, @dir, @tlf, @camas)");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }

        public async Task<int> UpdateHospAsync(Hospital hosp)
        {
            int registros;

            command.Parameters.Clear();

            SqlParameter paramId = new SqlParameter("@id", hosp.IdHospital);
            SqlParameter paramNombre = new SqlParameter("@nombre", hosp.NombreHospital);
            SqlParameter paramDir = new SqlParameter("@dir", hosp.DireccionHospital);
            SqlParameter paramTlf = new SqlParameter("@tlf", hosp.TelefonoHospital);
            SqlParameter paramNumCamas = new SqlParameter("@camas", hosp.NumeroCamas);
            command.Parameters.Add(paramId);
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramDir);
            command.Parameters.Add(paramTlf);
            command.Parameters.Add(paramNumCamas);

            await IniciarCommandAsync("update HOSPITAL set NOMBRE = @nombre, DIRECCION = @dir, TELEFONO = @tlf, NUM_CAMA = @camas WHERE HOSPITAL_COD = @id");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }

        public async Task<int> DeleteHospAsync(int id)
        {
            int registros;

            command.Parameters.Clear();

            SqlParameter paramId = new SqlParameter("@id", id);
            command.Parameters.Add(paramId);

            await IniciarCommandAsync("delete from HOSPITAL where HOSPITAL_COD = @id");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }
    }
}
