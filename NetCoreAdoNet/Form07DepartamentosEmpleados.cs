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
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDeptsEmps repo;

        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();

            repo = new RepositoryDeptsEmps();

            LoadDepts();
        }

        private async void LoadDepts()
        {
            List<string> depts = new List<string>();

            depts = await repo.LoadDeptsAsync();

            lstDepts.Items.Clear();
            foreach (string dept in depts)
            {
                lstDepts.Items.Add(dept);
            }
        }

        private async Task LoadEmps()
        {
            List<string> emps = new List<string>();

            emps = await repo.LoadEmpsAsync(lstDepts.SelectedItem.ToString());

            lstEmps.Items.Clear();
            foreach (string emp in emps)
            {
                lstEmps.Items.Add(emp);
            }
        }

        private async void lstDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadEmps();
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string emp = lstEmps.SelectedItem.ToString();
            await repo.DeleteEmpAsync(emp);

            await LoadEmps();
        }
    }
}
