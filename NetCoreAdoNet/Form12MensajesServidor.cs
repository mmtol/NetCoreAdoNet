using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from DEPT
//go

//create procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as
//	insert into DEPT VALUES (@numero, @nombre, @localidad)
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form12MensajesServidor : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();

            //string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            string stringConn = "";
            conn = new SqlConnection(stringConn);
            command = new SqlCommand();

            LoadDeptsAsync();
        }

        private async Task IniciarCommandAsync(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sql;
        }

        private async Task LoadDeptsAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            await IniciarCommandAsync(sql);

            command.Parameters.Clear();

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();

            lstDepartamentos.Items.Clear();
            while (await reader.ReadAsync())
            {
                string nombre = reader["DNOMBRE"].ToString();
                lstDepartamentos.Items.Add(nombre);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();
        }

        private async void btnNuevoDept_Click(object sender, EventArgs e)
        {
            int registros;

            string sql = "SP_INSERT_DEPARTAMENTO";
            await IniciarCommandAsync(sql);

            int numero = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            string localidad = txtLocalidad.Text;

            command.Parameters.Clear();
            SqlParameter paramNumero = new SqlParameter("@numero", numero);
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            SqlParameter paramLocalidad = new SqlParameter("@localidad", localidad);
            command.Parameters.Add(paramNumero);
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramLocalidad);

            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();

            await LoadDeptsAsync();
            MessageBox.Show("Se ha insertado " + registros + " departamento");
        }
    }
}
