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
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection conn;
        SqlCommand com;
        SqlDataReader reader;

        string cadenaConn;
        bool conectado;

        public Form01PrimerAdo()
        {
            InitializeComponent();

            lblConexion.BackColor = Color.LightCoral;

            cadenaConn = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";

            conn = new SqlConnection(cadenaConn);
            com = new SqlCommand();
            conn.StateChange += Conn_StateChange;
        }

        private void Conn_StateChange(object sender, StateChangeEventArgs e)
        {
            MessageBox.Show("La conn ha pasado de " + e.OriginalState + " a " + e.CurrentState);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!conectado)
                {
                    conn.Open();
                    lblConexion.Text = "     ";
                    lblConexion.BackColor = Color.LightGreen;

                    conectado = true;
                }
            }
            catch (SqlException ex)
            {
                lblConexion.Text = "ERROR 500";
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            conn.Close();
            lblConexion.Text = "     ";
            lblConexion.BackColor = Color.LightCoral;
            conectado = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                string sql = "select * from EMP";
                //indicamos la conn del command 
                com.Connection = conn;
                //tipo de consulta a realizar
                com.CommandType = CommandType.Text;
                //incluimos la consulta en el command
                com.CommandText = sql;
                //aqui deberiamos abrir la conn
                //ejecutar la consulta
                //como es un select utilizamos ExecuteReader() que devuelve un DataReader
                reader = com.ExecuteReader();
                //para la estructura de la tabla se utiliza for
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    //leemos la primera columna
                    string columna = this.reader.GetName(0);
                    //leemos el tipo de dato de la primera columna
                    string tipo = reader.GetDataTypeName(0);
                    //leemos el apellido de la primera columna
                    //debemos indicar el metodo read para leer registros
                    reader.Read();
                    string apellido = reader["APELLIDO"].ToString();

                    lstColumnas.Items.Add(columna);
                    lstTipos.Items.Add(tipo);
                    lstApellidos.Items.Add(apellido);
                }

                reader.Close();
            }
        }
    }
}
