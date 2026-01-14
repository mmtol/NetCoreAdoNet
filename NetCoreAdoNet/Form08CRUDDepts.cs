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
            List<Dept> depts = await repo.LoadDeptsAsync();
            foreach (Dept dept in depts)
            {
                lstDepts.Items.Add(dept.IdDept + " - " + dept.NombreDept + " - " + dept.LocalidadDept);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nombre = txtNombre.Text;
            string loc = txtLoc.Text;

            Dept dept = new Dept();
            dept.IdDept = id;
            dept.NombreDept = nombre;
            dept.LocalidadDept = loc;

            await repo.UpdateDeptAsync(dept);
            await LoadDepts();
        }

        private async void btnEiminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            await repo.DeleteDeptAsync(id);
            await LoadDepts();
        }
    }
}
