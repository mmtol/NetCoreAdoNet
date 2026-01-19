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
    public partial class Form10UpdateEmpleadosOficio : Form
    {
        RepositoryUpdateEmpleados repo;

        public Form10UpdateEmpleadosOficio()
        {
            InitializeComponent();

            repo = new RepositoryUpdateEmpleados();

            LoadOficios();
        }

        private async void LoadOficios()
        {
            lstOficios.Items.Clear();

            List<string> oficios = await repo.GetOficiosAsync();
            foreach (string oficio in oficios)
            {
                lstOficios.Items.Add(oficio);
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            if (lstOficios.SelectedIndex != -1)
            {
                int incremento = int.Parse(txtIncremento.Text);
                string oficio = lstOficios.SelectedItem.ToString();

                repo.UpdateSalarioEmpleadosAsync(oficio, incremento);
            }
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oficio = lstOficios.SelectedItem.ToString();

            await LoadEmpleados(oficio);
            await LoadDatosSalarios(oficio);
        }

        private async Task LoadDatosSalarios(string oficio)
        {
            await LoadSumaSalarialAsync(oficio);
            await LoadMediaSalarialAsync(oficio);
            await LoadMaxSalarioAsync(oficio);
        }

        private async Task LoadSumaSalarialAsync(string oficio)
        {
            string sql = "select SUM(SALARIO) as DATO from EMP where OFICIO = @oficio";
            int suma = await repo.GetDatoSalarioOficioAsync(oficio, sql);

            lblSumaSalarial.Text = "Suma: " + suma.ToString();
        }

        private async Task LoadMediaSalarialAsync(string oficio)
        {
            string sql = "select AVG(SALARIO) as DATO from EMP where OFICIO = @oficio";
            int media = await repo.GetDatoSalarioOficioAsync(oficio, sql);

            lblMediaSalarial.Text = "Media: " + media.ToString();
        }

        private async Task LoadMaxSalarioAsync(string oficio)
        {
            string sql = "select MAX(SALARIO) as DATO from EMP where OFICIO = @oficio";
            int max = await repo.GetDatoSalarioOficioAsync(oficio, sql);

            lblMaximoSalario.Text = "Max: " + max.ToString();
        }

        private async Task LoadEmpleados(string oficio)
        {
            lstEmpleados.Items.Clear();

            List<string> empleados = await repo.GetEmpleadosOficioAsync(oficio);
            foreach (string ofi in empleados)
            {
                lstEmpleados.Items.Add(ofi);
            }
        }
    }
}
