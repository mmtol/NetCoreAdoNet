using AdoNetPracticaFinal.Helper;
using AdoNetPracticaFinal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

#region STORED PROCEDURE
//drop procedure if exists SP_LOAD_DEPTS
//create procedure SP_LOAD_DEPTS
//as
//	select * from DEPT
//go

//drop procedure if exists SP_LOAD_EMPS_DEPT
//create procedure SP_LOAD_EMPS_DEPT
//(@deptno int)
//as
//	select APELLIDO, OFICIO, SALARIO from EMP where DEPT_NO = @deptno
//go

//drop procedure if exists SP_INSERT_DEPT
//create procedure SP_INSERT_DEPT
//(@deptno int, @dnombre nvarchar(50), @loc nvarchar(50))
//as
//	insert into DEPT values (@deptno, @dnombre, @loc)
//go

//drop procedure if exists SP_UPDATE_EMP
//create procedure SP_UPDATE_EMP
//(@apellido nvarchar(50), @oficio nvarchar(50), @salario int)
//as
//	update EMP set OFICIO = @oficio, SALARIO = @salario where APELLIDO = @apellido
//go
//drop procedure if exists SP_LOAD_DEPT
//create procedure SP_LOAD_DEPT
//(@deptno int)
//as
//	select * from DEPT where DEPT_NO = @deptno
//go
//drop procedure if exists SP_LOAD_EMP
//create procedure SP_LOAD_EMP
//(@apellido nvarchar(50))
//as
//	select APELLIDO, OFICIO, SALARIO from EMP where APELLIDO = @apellido
//go
#endregion

namespace AdoNetPracticaFinal.Repositories
{
    public class RepositoryFinal
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public RepositoryFinal()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");

            conn = new SqlConnection(connectionString);
            command = new SqlCommand();
        }

        private void InicializarCommand(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sql;
        }

        public async Task<List<Departamento>> LoadDeptsAsync()
        {
            List<Departamento> depts = new List<Departamento>();

            string sql = "SP_LOAD_DEPTS";
            command.Parameters.Clear();
            InicializarCommand(sql);
            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Departamento dept = new Departamento();
                dept.DeptNo = int.Parse(reader["DEPT_NO"].ToString());
                dept.DNombre = reader["DNOMBRE"].ToString();
                dept.Loc = reader["LOC"].ToString();

                depts.Add(dept);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();

            return depts;
        }

        public async Task<List<Empleado>> LoadEmpsDeptAsync(int deptNo)
        {
            List<Empleado> emps = new List<Empleado>();

            string sql = "SP_LOAD_EMPS_DEPT";

            command.Parameters.Clear();
            SqlParameter paramDepNo = new SqlParameter("@deptno", deptNo);
            command.Parameters.Add(paramDepNo);

            InicializarCommand(sql);
            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Empleado emp = new Empleado();
                emp.Apellido = reader["APELLIDO"].ToString();
                emp.Oficio = reader["OFICIO"].ToString();
                emp.Salario = int.Parse(reader["SALARIO"].ToString());

                emps.Add(emp);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();

            return emps;
        }

        public async Task<int> InsertDeptAsync(Departamento dept)
        {
            int registros = 0;

            string sql = "SP_INSERT_DEPT";

            command.Parameters.Clear();
            SqlParameter paramDepNo = new SqlParameter("@deptno", dept.DeptNo);
            SqlParameter paramDNombre = new SqlParameter("@dnombre", dept.DNombre);
            SqlParameter paramLoc = new SqlParameter("@loc", dept.Loc);
            command.Parameters.Add(paramDepNo);
            command.Parameters.Add(paramDNombre);
            command.Parameters.Add(paramLoc);

            InicializarCommand(sql);
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();

            return registros;
        }

        public async Task<int> UpdateEmpAsync(Empleado emp)
        {
            int registros = 0;

            string sql = "SP_UPDATE_EMP";
            command.Parameters.Clear();
            SqlParameter paramApellido = new SqlParameter("@apellido", emp.Apellido);
            SqlParameter paramOficio = new SqlParameter("@oficio", emp.Oficio);
            SqlParameter paramSalario = new SqlParameter("@salario", emp.Salario);
            command.Parameters.Add(paramApellido);
            command.Parameters.Add(paramOficio);
            command.Parameters.Add(paramSalario);

            InicializarCommand(sql);
            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();

            return registros;
        }

        public async Task<Departamento> LoadDeptAsync(int deptNo)
        {
            Departamento dept = new Departamento();

            string sql = "SP_LOAD_DEPT";

            command.Parameters.Clear();
            SqlParameter paramDepNo = new SqlParameter("@deptno", deptNo);
            command.Parameters.Add(paramDepNo);

            InicializarCommand(sql);
            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();

            await reader.ReadAsync();
            dept.DeptNo = int.Parse(reader["DEPT_NO"].ToString());
            dept.DNombre = reader["DNOMBRE"].ToString();
            dept.Loc = reader["LOC"].ToString();

            await reader.CloseAsync();
            await conn.CloseAsync();

            return dept;
        }

        public async Task<Empleado> LoadEmpAsync(string apellido)
        {
            Empleado emp = new Empleado();

            string sql = "SP_LOAD_EMP";
            command.Parameters.Clear();
            SqlParameter paramApellido = new SqlParameter("@apellido", apellido);
            command.Parameters.Add(paramApellido);

            InicializarCommand(sql);
            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();

            await reader.ReadAsync();
            emp.Apellido = reader["APELLIDO"].ToString();
            emp.Oficio = reader["OFICIO"].ToString();
            emp.Salario = int.Parse(reader["SALARIO"].ToString());

            await reader.CloseAsync();
            await conn.CloseAsync();

            return emp;
        }
    }
}
