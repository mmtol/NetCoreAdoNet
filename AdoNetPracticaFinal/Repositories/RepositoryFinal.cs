using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Extensions.Configuration;

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
#endregion

namespace AdoNetPracticaFinal.Repositories
{
    public  class RepositoryFinal
    {
        public RepositoryFinal() 
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);

        }
    }
}
