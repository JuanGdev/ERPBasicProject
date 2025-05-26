using System;
using System.Linq;
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
            Tasks tasksForm = new Tasks();
            tasksForm.Show();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            Departments departmentsForm = new Departments();
            departmentsForm.Show();
        }

        private void btnAdminRoles_Click(object sender, EventArgs e)
        {
            Administration adminForm = new Administration();
            adminForm.Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            Projects projectsForm = new Projects();
            projectsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a copy of the OpenForms collection to avoid modification during enumeration
            var formsToClose = Application.OpenForms.Cast<Form>().ToList();

            foreach (Form form in formsToClose)
            {
                if (form is MenuForm || form is Form1 || form is Administration || form is Projects || form is FormEmployees || form is Tasks || form is Departments)
                {
                    form.Close();
                }
            }
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Create a copy of the OpenForms collection to avoid modification during enumeration
            var formsToClose = Application.OpenForms.Cast<Form>().ToList();

            foreach (Form form in formsToClose)
            {
                if (form is Administration || form is Projects || form is FormEmployees || form is Tasks || form is Departments)
                {
                    form.Close();
                }
            }

            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Close(); // Cierra el formulario actual
        }


    }
}

