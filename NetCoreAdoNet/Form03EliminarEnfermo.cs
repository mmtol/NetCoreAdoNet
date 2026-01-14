using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();

            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

            conn = new SqlConnection(stringConn);
            command = new SqlCommand();

            LoadEnfermos();
        }

        private void LoadEnfermos()
        {
            string sql = "select * from ENFERMO";
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            conn.Open();
            reader = command.ExecuteReader();

            lstEnfermos.Items.Clear();
            while (reader.Read())
            {
                string inscripcion = reader["INSCRIPCION"].ToString();
                string apellido = reader["APELLIDO"].ToString();

                lstEnfermos .Items.Add(inscripcion + " - " + apellido);
            }

            reader.Close();
            conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //necesitamos el dato de inscripcion concatenado
            // los params deben ser del mismo tipo de dato que la columna
            int inscripcion = int.Parse(txtId.Text);
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            //debemos configurar uno o varios params
            SqlParameter paramIns = new SqlParameter("@inscripcion", inscripcion);
            ////nombre del param en la consulta, no puede estar repetido
            //paramIns.ParameterName = "@inscripcion";
            //paramIns.DbType = DbType.Int32;
            ////por defecto la dir es input
            //paramIns.Direction = ParameterDirection.Input;
            ////el valor del param para sustituir en la consulta
            //paramIns.Value = inscripcion;
            ////agregamos el param a la coleccion
            command.Parameters.Add(paramIns);

            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            conn.Open();
            //las consultas de accion devuelven un int con el numero de los registros afectados
            int registros = command.ExecuteNonQuery();
            conn.Close();
            //hay que quitarlos para volver a hacerlo
            command.Parameters.Clear();
            LoadEnfermos();
            MessageBox.Show("Enfermos eliminados: " + registros);
        }
    }
}
