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
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader reader;

        public Form05UpdateSalas()
        {
            InitializeComponent();

            string stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

            conn = new SqlConnection(stringConn);
            command = new SqlCommand();

            LoadSalas();
        }

        private void IniciarCommand(string sql)
        {
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
        }

        private void LoadSalas()
        {
            IniciarCommand("select distinct NOMBRE from SALA");
            conn.Open();
            reader = command.ExecuteReader();

            lstSalas.Items.Clear();
            while (reader.Read())
            {
                string nombre = reader["NOMBRE"].ToString();
                lstSalas .Items.Add(nombre);
            }

            reader.Close();
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command.Parameters.Clear();

            string nuevo = txtNombre.Text;
            string viejo = lstSalas.SelectedItem.ToString();

            string sql = "Update SALA set NOMBRE=@nuevo where NOMBRE=@viejo";
            SqlParameter paramNuevo = new SqlParameter("@nuevo", nuevo);
            SqlParameter paramViejo = new SqlParameter("@viejo", viejo);

            command.Parameters.Add(paramNuevo);
            command.Parameters.Add(paramViejo);

            IniciarCommand(sql);

            conn.Open();
            int registros = command.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Salas modificadas: " + registros);
            LoadSalas();
        }
    }
}
