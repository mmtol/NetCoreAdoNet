using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form09CRUDHospital : Form
    {
        private RepositoryHospitales repo;

        public Form09CRUDHospital()
        {
            InitializeComponent();

            repo = new RepositoryHospitales();

            LoadHospAsync();
        }

        private async void LoadHospAsync()
        {
            lstHosp.Items.Clear();

            List<Hospital> hospitales =  await repo.LoadHospitalesAsync();
            foreach (Hospital hosp in hospitales)
            {
                lstHosp.Items.Add(hosp.IdHospital + " - " + hosp.NombreHospital + " - " + hosp.DireccionHospital + " - " + hosp.TelefonoHospital + " - " + hosp.NumeroCamas);
            }
        }

        private async Task<Hospital> CrearHospAsync()
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            string dir = txtDir.Text;
            string tlf = txtTlf.Text;
            int camas = int.Parse(txtCamas.Text);

            Hospital hospital = new Hospital();
            hospital.IdHospital = id;
            hospital.NombreHospital = nombre;
            hospital.DireccionHospital = dir;
            hospital.TelefonoHospital = tlf;
            hospital.NumeroCamas = camas;

            return hospital;
        }

        private async Task LimpiarTxtAsync()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDir.Clear();
            txtTlf.Clear();
            txtCamas.Clear();
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            Hospital hospital = await CrearHospAsync();

            await repo.InsertHospAsync(hospital);
            LoadHospAsync();

            await LimpiarTxtAsync();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            Hospital hospital = await CrearHospAsync();

            await repo.UpdateHospAsync(hospital);
            LoadHospAsync();

            await LimpiarTxtAsync();
        }

        private async void btnEiminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            await repo.DeleteHospAsync(id);
            LoadHospAsync();

            await LimpiarTxtAsync();
        }

        private void lstHosp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] datos = lstHosp.SelectedItem.ToString().Split(" - ");

            Hospital hospital = new Hospital();
            hospital.IdHospital = int.Parse(datos[0]);
            hospital.NombreHospital = datos[1];
            hospital.DireccionHospital = datos[2];
            hospital.TelefonoHospital = datos[3];
            hospital.NumeroCamas = int.Parse(datos[4]);

            txtID.Text = hospital.IdHospital.ToString();
            txtNombre.Text = hospital.NombreHospital;
            txtDir.Text = hospital.DireccionHospital;
            txtTlf.Text = hospital.TelefonoHospital;
            txtCamas.Text = hospital.NumeroCamas.ToString();
        }
    }
}
