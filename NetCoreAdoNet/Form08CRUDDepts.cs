using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetCoreAdoNet.Models;
using System.Threading.Tasks;

namespace NetCoreAdoNet
{
    public partial class Form08CRUDDepts : Form
    {
        RepositoryDepts repo;

        public Form08CRUDDepts()
        {
            InitializeComponent();

            repo = new RepositoryDepts();

            LoadDepts();
        }

        private async Task LoadDepts()
        {
            lstDepts.Items.Clear();

            List<Dept> depts = await repo.LoadDeptsAsync();
            foreach (Dept dept in depts)
            {
                lstDepts.Items.Add(dept.IdDept + " - " + dept.NombreDept + " - " + dept.LocalidadDept);
            }
        }

        private async Task<Dept> CrearDeptAsync()
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            string loc = txtLoc.Text;

            Dept dept = new Dept();
            dept.IdDept = id;
            dept.NombreDept = nombre;
            dept.LocalidadDept = loc;

            return dept;
        }

        private async Task LimpiarTxtAsync()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtLoc.Clear();
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            Dept dept = await CrearDeptAsync();

            await repo.InsertDeptAsync(dept);
            await LoadDepts();

            await LimpiarTxtAsync();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            Dept dept = await CrearDeptAsync();

            await repo.UpdateDeptAsync(dept);
            await LoadDepts();

            await LimpiarTxtAsync();
        }

        private async void btnEiminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            await repo.DeleteDeptAsync(id);
            await LoadDepts();

            await LimpiarTxtAsync();
        }

        private void lstDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] datos = lstDepts.SelectedItem.ToString().Split(" - ");

            Dept dept = new Dept();
            dept.IdDept = int.Parse(datos[0]);
            dept.NombreDept = datos[1];
            dept.LocalidadDept = datos[2];

            txtID.Text = dept.IdDept.ToString();
            txtNombre.Text = dept.NombreDept;
            txtLoc.Text = dept.LocalidadDept;
        }
    }
}
