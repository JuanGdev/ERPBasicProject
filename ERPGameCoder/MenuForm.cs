using System;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class MenuForm : Form
    {
        private string userType;

        public MenuForm(string userType)
        {
            InitializeComponent();
            this.userType = userType;
            ConfigurePermissions();
        }

        private void ConfigurePermissions()
        {
            // Desactivar botones según el tipo de usuario
            if (userType == "User")
            {
                btnEmployees.Enabled = false;
                btnTasks.Enabled = false;
                btnDepartments.Enabled = false;
                btnUsers.Enabled = false;
            }
            // Si es Admin, no se desactiva ningún botón
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            // Abrir formulario de tareas
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            Departments departmentsForm = new Departments();
            departmentsForm.Show();
        }

        private void btnAdminRoles_Click(object sender, EventArgs e)
        {
            // Abrir formulario de administración de roles
        }
    }
}

