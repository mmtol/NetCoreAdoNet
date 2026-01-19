using Microsoft.Data.SqlClient;
using System.Data;

namespace NetCoreAdoNet
{
    #region PROCEDIMIENTOS ALMACENADOS
    //    create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
    //(@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int out)
    //as
    //	declare @iddept int
    //    select @iddept = DEPT_NO from DEPT where DNOMBRE = @nombre
    //	-- la consulta del procedimiento

    //    select* from EMP where DEPT_NO = @iddept
    //	-- rellenamos las variables de salida
    //    select @suma = SUM(SALARIO), @media = AVG(SALARIO), @personas = COUNT(EMP_NO)

    //    from EMP

    //    where DEPT_NO = @iddept
    //go
    #endregion

    public partial class Form13ParametrosSalida : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;

        public Form13ParametrosSalida()
        {
            InitializeComponent();

            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            conn = new SqlConnection(stringConn);
            command = new SqlCommand();
            command.Connection = conn;

            LoadDepartamentos();
        }

        private async Task LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            cmbDepartamentos.Items.Clear();
            while (await reader.ReadAsync())
            {
                string nombre = reader["DNOMBRE"].ToString();
                cmbDepartamentos.Items.Add(nombre);
            }

            await reader.CloseAsync();
            await conn.CloseAsync();
        }

        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            string nombre = cmbDepartamentos.SelectedItem.ToString();

            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            command.Parameters.Add(paramNombre);

            // en este ejemplo no hemos puesto valores por defecto
            // por lo que son obligatorios
            SqlParameter paramSuma = new SqlParameter("@suma", 0);
            paramSuma.Direction = ParameterDirection.Output;

            SqlParameter paramMedia = new SqlParameter("@media", 0);
            paramSuma.Direction = ParameterDirection.Output;

            SqlParameter paramPersonas = new SqlParameter("@personas", 0);
            paramSuma.Direction = ParameterDirection.Output;

            command.Parameters.Add(paramSuma);
            command.Parameters.Add(paramMedia);
            command.Parameters.Add(paramPersonas);

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = sql;

            await conn.OpenAsync();
            reader = await command.ExecuteReaderAsync();
            lstEmpleados.Items.Clear();
            while (await reader.ReadAsync())
            {
                string apellido = reader["APELLIDO"].ToString();
                lstEmpleados.Items.Add(apellido);
            }

            await reader.CloseAsync();

            // dibujamos los parametros
            txtSumaSalarial.Text = paramSuma.Value.ToString();
            txtMediaSalarial.Text = paramMedia.Value.ToString();
            txtPersonas.Text = paramPersonas.Value.ToString();

            // liberamos los recursos
            await conn.CloseAsync();
            command.Parameters.Clear();
        }
    }
}
