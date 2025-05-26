using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class Administration : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        public Administration()
        {
            InitializeComponent();
            LoadUsers();
            LoadRoles(); // Cargar roles al iniciar el formulario
            LoadProjectsTasksAndEmployees();
            btnAddUser.Click += BtnAddUser_Click;
            btnEditUser.Click += BtnEditUser_Click;
            btnDeleteUser.Click += BtnDeleteUser_Click;
        }

        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId, FullName, Email, UserType FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable usersTable = new DataTable();
                adapter.Fill(usersTable);
                dgvUsers.DataSource = usersTable;
            }
        }

        private void LoadProjectsTasksAndEmployees()
        {
            string query = @"
                SELECT 
                    p.Name AS ProjectName, 
                    t.Name AS TaskName, 
                    e.Name AS EmployeeName, 
                    e.Email AS EmployeeEmail
                FROM 
                    Projects p
                INNER JOIN 
                    Tasks t ON p.ProjectId = t.ProjectId
                INNER JOIN 
                    Employees e ON t.EmployeeId = e.EmployeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dvgProjectsTaskAndEmployees.DataSource = table;
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users (FullName, Email, UserPassword, UserType) 
                         VALUES (@FullName, @Email, @UserPassword, @UserType)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Aquí puedes usar controles de entrada como TextBox para capturar los datos del usuario
                cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text); // Asegúrate de manejar contraseñas de forma segura
                cmd.Parameters.AddWithValue("@UserType", cmbRole.SelectedItem?.ToString() ?? "User");

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            LoadUsers(); // Recarga la lista de usuarios
            ClearFields(); // Limpia los campos de entrada
        }

        private void BtnEditUser_Click(object sender, EventArgs e)
        {

            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Obtener el UserId del usuario seleccionado
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);

                // Validar que los campos de entrada no estén vacíos
                if (string.IsNullOrWhiteSpace(txtFullname.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Users 
                             SET FullName = @FullName, 
                                 Email = @Email, 
                                 UserPassword = @UserPassword, 
                                 UserType = @UserType 
                             WHERE UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asignar los valores de los controles de entrada
                    cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text); // Maneja contraseñas de forma segura
                    cmd.Parameters.AddWithValue("@UserType", cmbRole.SelectedItem?.ToString() ?? "User");
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                // Recargar la lista de usuarios
                LoadUsers();
                ClearFields(); // Limpiar los campos de entrada
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Cargar los datos del usuario seleccionado en los controles de entrada
                txtFullname.Text = dgvUsers.SelectedRows[0].Cells["FullName"].Value.ToString();
                txtEmail.Text = dgvUsers.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = ""; // No mostrar contraseñas directamente
                cmbRole.SelectedItem = dgvUsers.SelectedRows[0].Cells["UserType"].Value.ToString();
            }
        }

        private void LoadRoles()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserType FROM Users"; // Asume que tienes una tabla 'Roles'
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                cmbRole.Items.Clear();
                while (reader.Read())
                {
                    cmbRole.Items.Add(reader["UserType"].ToString());
                }
            }
        }



        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserId"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE UserId = @UserId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void ClearFields()
        {
            txtFullname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }
    }
}
