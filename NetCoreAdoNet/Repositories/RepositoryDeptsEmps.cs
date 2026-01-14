using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDeptsEmps
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public RepositoryDeptsEmps()
        {
            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

            conn = new SqlConnection(stringConn);
            command = new SqlCommand();
        }

        private void IniciarCommand(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
        }

        public async Task<List<string>> LoadDeptsAsync()
        {
            List<string> depts = new List<string>();

            IniciarCommand("select DNOMBRE from DEPT");
            await conn.OpenAsync();

            reader = command.ExecuteReader();
            while (await reader.ReadAsync())
            {
                depts.Add(reader["DNOMBRE"].ToString());
            }

            await conn.CloseAsync();
            await reader.CloseAsync();

            return depts;
        }

        public async Task<List<string>> LoadEmpsAsync(string dept)
        {
            List<string> emps = new List<string>();

            IniciarCommand("select EMP.APELLIDO from EMP inner join DEPT on EMP.DEPT_NO = DEPT.DEPT_NO where DEPT.DNOMBRE = '" + dept+"'");
            await conn.OpenAsync();

            reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                emps.Add(reader["APELLIDO"].ToString());
            }

            await conn.CloseAsync();
            await reader.CloseAsync();

            return emps;
        }

        public async Task<int> DeleteEmpAsync(string apellido)
        {
            int registros;

            IniciarCommand("delete from EMP where APELLIDO = '" + apellido + "'");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }
    }
}
