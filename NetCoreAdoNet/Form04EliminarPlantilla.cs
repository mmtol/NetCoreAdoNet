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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public Form04EliminarPlantilla()
        {
            InitializeComponent();

            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

            conn = new SqlConnection(stringConn);
            command = new SqlCommand();

            LoadPlantilla();
        }

        private void CrearCommand(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
        }

        private void LoadPlantilla()
        {
            lstPlantilla.Items.Clear();

            CrearCommand("select EMPLEADO_NO, APELLIDO from PLANTILLA");
            conn.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["EMPLEADO_NO"].ToString();
                string apellido = reader["APELLIDO"].ToString();

                lstPlantilla.Items.Add(id + " - " + apellido);
            }

            reader.Close();
            conn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            CrearCommand("delete from PLANTILLA where EMPLEADO_NO=" + id);
            conn.Open();
            int registros = command.ExecuteNonQuery();
            conn.Close();

            LoadPlantilla();
            MessageBox.Show("Trabajadores eliminados: " + registros);
        }
    }
}
