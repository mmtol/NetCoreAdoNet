using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using NetCoreAdoNet.Models;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepts
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public RepositoryDepts()
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

        public async Task<List<Dept>> LoadDeptsAsync()
        {
            List<Dept> depts = new List<Dept>();

            IniciarCommand("select * from DEPT");
            await conn.OpenAsync();

            reader = command.ExecuteReader();
            while (await reader.ReadAsync())
            {
                int id = int.Parse(reader["DEPT_NO"].ToString());
                string nombre = reader["DNOMBRE"].ToString();
                string localidad = reader["LOC"].ToString();

                Dept dept = new Dept();
                dept.IdDept = id;
                dept.NombreDept = nombre;
                dept.LocalidadDept = localidad;

                depts.Add(dept);
            }

            await conn.CloseAsync();
            await reader.CloseAsync();

            return depts;
        }

        public async Task<int> InsertDeptAsync(Dept dept)
        {
            int registros;

            SqlParameter paramId = new SqlParameter("@id", dept.IdDept);
            SqlParameter paramNombre = new SqlParameter("@nombre", dept.NombreDept);
            SqlParameter paramLoc = new SqlParameter("@loc", dept.LocalidadDept);
            command.Parameters.Add(paramId);
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramLoc);

            IniciarCommand("insert into DEPT VALUES (@id, @nombre, @loc)");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }

        public async Task<int> UpdateDeptAsync(Dept dept)
        {
            int registros;

            SqlParameter paramId = new SqlParameter("@id", dept.IdDept);
            SqlParameter paramNombre = new SqlParameter("@nombre", dept.NombreDept);
            SqlParameter paramLoc = new SqlParameter("@loc", dept.LocalidadDept);
            command.Parameters.Add(paramId);
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramLoc);

            IniciarCommand("update DEPT set DNOMBRE=@nombre, LOC=@loc where DEPT_NO=@id");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }

        public async Task<int> DeleteDeptAsync(int id)
        {
            int registros;

            SqlParameter paramId = new SqlParameter("@id", id);
            command.Parameters.Add(paramId);

            IniciarCommand("delete from DEPT where DEPT_NO = @id");
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            return registros;
        }
    }
}
