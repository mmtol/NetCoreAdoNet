using AdoNetPracticaFinal.Models;
using AdoNetPracticaFinal.Repositories;

namespace AdoNetPracticaFinal
{
    public partial class FormFinal : Form
    {
        private RepositoryFinal repo;

        public FormFinal()
        {
            InitializeComponent();

            repo = new RepositoryFinal();

            LoadDepts();
        }

        private async Task LoadDepts()
        {
            List<Departamento> depts = new List<Departamento>();
            depts = await repo.LoadDeptsAsync();

            cmbDepts.Items.Clear();
            foreach (Departamento dept in depts)
            {
                cmbDepts.Items.Add(dept.DeptNo);
            }
        }

        private async void btnInsertarDept_Click(object sender, EventArgs e)
        {
            Departamento dept = new Departamento();
            dept.DeptNo = int.Parse(txtId.Text);
            dept.DNombre = txtNombre.Text;
            dept.Loc = txtLocalidad.Text;

            int registros = await repo.InsertDeptAsync(dept);
            MessageBox.Show("Se ha modificado " + registros + " registro.");
            LoadDepts();
        }

        private async void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Apellido = txtApellido.Text;
            emp.Oficio = txtOficio.Text;
            emp.Salario = int.Parse(txtSalario.Text);

            int registros = await repo.UpdateEmpAsync(emp);
            MessageBox.Show("Se ha modificado " + registros + " registro.");
            await LoadEmpsAsync(int.Parse(cmbDepts.SelectedItem.ToString()));
        }

        private async void cmbDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deptNo = int.Parse(cmbDepts.SelectedItem.ToString());

            await MostrarDept(deptNo);
            await LoadEmpsAsync(deptNo);
        }

        private async Task MostrarDept(int deptNo)
        {
            Departamento dept = await repo.LoadDeptAsync(deptNo);

            txtId.Text = dept.DeptNo.ToString();
            txtNombre.Text = dept.DNombre;
            txtLocalidad.Text = dept.Loc;
        }

        private async Task LoadEmpsAsync(int deptNo)
        {
            List<Empleado> emps = await repo.LoadEmpsDeptAsync(deptNo);

            lstEmpleados.Items.Clear();
            foreach (Empleado emp in emps)
            {
                lstEmpleados.Items.Add(emp.Apellido);
            }
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string apellido = lstEmpleados.SelectedItem.ToString();

            Empleado emp = await repo.LoadEmpAsync(apellido);
            txtApellido.Text = emp.Apellido;
            txtOficio.Text = emp.Oficio;
            txtSalario.Text = emp.Salario.ToString();
        }
    }
}
