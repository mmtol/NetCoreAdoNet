using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization.Json;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public  class RepositoryUpdateEmpleados
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
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

        public async Task<List<string>> GetOficiosAsync()
        {
            List<string> oficios = new List<string>();

            string sql = "select distinct OFICIO from EMP";
            await IniciarCommandAsync(sql);

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                oficios.Add(reader["OFICIO"].ToString());
            }

            await reader.CloseAsync();
            await conn.CloseAsync();

            return oficios;
        }

        public async Task<List<string>> GetEmpleadosOficioAsync(string oficio)
        {
            List<string> empleados = new List<string>();

            command.Parameters.Clear();

            SqlParameter paramOficio = new SqlParameter("@oficio", oficio);
            command.Parameters.Add(paramOficio);

            string sql = "select distinct APELLIDO from EMP where OFICIO = @oficio";
            await IniciarCommandAsync(sql);

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                empleados.Add(reader["APELLIDO"].ToString());
            }

            await reader.CloseAsync();
            await conn.CloseAsync();

            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio, int incremento)
        {
            int registros;

            command.Parameters.Clear();

            SqlParameter paramOficio = new SqlParameter("@oficio", oficio);
            SqlParameter paramIncremento = new SqlParameter("@incremento", incremento);
            command.Parameters.Add(paramOficio);
            command.Parameters.Add(paramIncremento);

            string sql = "update EMP set SALARIO = SALARIO + @incremento where OFICIO = @oficio";
            await IniciarCommandAsync(sql);

            await conn.OpenAsync();
            registros = command.ExecuteNonQuery();

            await conn.CloseAsync();

            return registros;
        }

        public async Task<int> GetDatoSalarioOficioAsync(string oficio, string sql)
        {
            int dato;

            command.Parameters.Clear();

            SqlParameter paramOficio = new SqlParameter("@oficio", oficio);
            command.Parameters.Add(paramOficio);

            await IniciarCommandAsync(sql);

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            dato = reader

            return dato;
        }
    }
}
