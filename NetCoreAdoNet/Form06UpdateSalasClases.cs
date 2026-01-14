using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form06UpdateSalasClases : Form
    {
        RepositorySalas repo;

        public Form06UpdateSalasClases()
        {
            InitializeComponent();

            repo = new RepositorySalas();

            LoadSalasAsync();
        }

        private async void LoadSalasAsync()
        {
            List<string> salas = new List<string>();
            salas = await repo.GetNombreSalasAsync();

            lstSalas.Items.Clear();
            foreach(string sala in salas)
            {
                lstSalas.Items.Add(sala);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string nuevo = txtNombre.Text;
            string viejo = lstSalas.SelectedItem.ToString();

            await repo.UpdateSalaAsync(nuevo, viejo);
            LoadSalasAsync();
        }
    }
}
