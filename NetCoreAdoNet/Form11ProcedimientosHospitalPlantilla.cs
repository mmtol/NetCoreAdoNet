using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_ALL_HOSPITALES
//as
//	select * from HOSPITAL
//go

//create procedure SP_UPDATE_PLANTILLA_HOSPITAL
//(@nombre as nvarchar(50), @incremento int)
//as
//	declare @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD 
//	from HOSPITAL 
//	where NOMBRE = @nombre
//	update PLANTILLA set SALARIO = SALARIO + @incremento 
//	where HOSPITAL_COD = @hospitalcod
//go

//create procedure SP_PLANTILLA_HOSPITAL
//(@nombre nvarchar(50))
//as
//	select PLANTILLA.* 
//	from PLANTILLA inner join HOSPITAL on HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD 
//	where HOSPITAL.NOMBRE = @nombre
//go
#endregion

namespace NetCoreAdoNet
{
    public partial class Form11ProcedimientosHospitalPlantilla : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public Form11ProcedimientosHospitalPlantilla()
        {
            InitializeComponent();

            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            conn = new SqlConnection(stringConn);
            command = new SqlCommand();

            LoadHospitalesAsync();
        }

        private async Task IniciarCommandAsync(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sql;
        }

        private async Task LoadHospitalesAsync()
        {
            string sql = "SP_ALL_HOSPITALES";
            await IniciarCommandAsync(sql);

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();

            cmbHospitales.Items.Clear();
            while (await reader.ReadAsync())
            {
                string nombre = reader["NOMBRE"].ToString();
                cmbHospitales.Items.Add(nombre);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int registros;

            string nombre = cmbHospitales.SelectedItem.ToString();
            int incremento = int.Parse(txtIncremento.Text);

            string sql = "SP_UPDATE_PLANTILLA_HOSPITAL";
            await IniciarCommandAsync(sql);

            command.Parameters.Clear();
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            SqlParameter paramIncremento = new SqlParameter("@incremento", incremento);
            command.Parameters.Add(paramNombre);
            command.Parameters.Add(paramIncremento);

            await conn.OpenAsync();
            registros = await command.ExecuteNonQueryAsync();
            await conn.CloseAsync();

            await LoadPlantillaAsync();

            MessageBox.Show("Registros modificados: " + registros);
        }

        private async Task LoadPlantillaAsync()
        {
            string nombre = cmbHospitales.SelectedItem.ToString();

            string sql = "SP_PLANTILLA_HOSPITAL";
            await IniciarCommandAsync(sql);

            command.Parameters.Clear();
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            command.Parameters.Add(paramNombre);

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();

            lstPlantilla.Items.Clear();
            while (await reader.ReadAsync())
            {
                string apellido = reader["APELLIDO"].ToString();
                int salario = int.Parse(reader["SALARIO"].ToString());

                lstPlantilla.Items.Add(apellido + " - " + salario);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();
        }
    }
}
