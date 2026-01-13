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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection conn;
        SqlCommand com;
        SqlDataReader reader;

        string stringConn;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();

            stringConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            
            conn = new SqlConnection(stringConn);
            com = new SqlCommand();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int salario = int.Parse(txtSalario.Text);
            string sql = "select * from EMP where SALARIO >= " + salario;

            conn.Open();
            com.Connection = conn;
            com.CommandType = CommandType.Text;
            com.CommandText = sql;
            reader = com.ExecuteReader();

            lstEmpleados.Items.Clear();
            while (reader.Read())
            {
                string apellido = reader["APELLIDO"].ToString();
                string sal = reader["SALARIO"].ToString();

                lstEmpleados .Items.Add(apellido + ", " + sal);
            }

            reader.Close();
            conn.Close();
        }
    }
}
