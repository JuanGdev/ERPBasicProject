using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class FormEmployees : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public FormEmployees()
        {
            InitializeComponent();
            LoadDepartments(); // Cargar los departamentos al iniciar el formulario
            LoadEmployees(); // Cargar los empleados al iniciar el formulario
        }

        private void LoadDepartments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DepartmentId, Name FROM Departments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBoxDepartment.DataSource = table; // Asignar la tabla como fuente de datos
                comboBoxDepartment.DisplayMember = "Name"; // Mostrar el nombre del departamento
                comboBoxDepartment.ValueMember = "DepartmentId"; // Usar el ID del departamento internamente
                comboBoxDepartment.SelectedIndex = -1; // Ningún valor seleccionado por defecto
            }
        }
        private void LoadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT e.EmployeeId, e.Name, e.Email, d.Name AS Department, e.HireDate, e.Salary
            FROM Employees e
            INNER JOIN Departments d ON e.DepartmentId = d.DepartmentId";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewEmployees.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO Employees (Name, Email, DepartmentId, HireDate, Salary)
            VALUES (@Name, @Email, @DepartmentId, @HireDate, @Salary)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@DepartmentId", comboBoxDepartment.SelectedValue);
                command.Parameters.AddWithValue("@HireDate", dtpHireDate.Value);
                command.Parameters.AddWithValue("@Salary", decimal.Parse(txtSalary.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadEmployees(); // Recargar los datos
            ClearFields(); // Limpiar los campos
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                UPDATE Employees
                SET Name = @Name, Email = @Email, DepartmentId = @DepartmentId, HireDate = @HireDate, Salary = @Salary
                WHERE EmployeeId = @EmployeeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@DepartmentId", comboBoxDepartment.SelectedValue);
                    command.Parameters.AddWithValue("@HireDate", dtpHireDate.Value);
                    command.Parameters.AddWithValue("@Salary", decimal.Parse(txtSalary.Text));
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadEmployees(); // Recargar los datos
                ClearFields(); // Limpiar los campos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para editar.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["EmployeeId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadEmployees(); // Recargar los datos
                ClearFields(); // Limpiar los campos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un empleado para eliminar.");
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            comboBoxDepartment.SelectedIndex = -1;
            txtSalary.Clear();
            dtpHireDate.Value = DateTime.Now;
        }

        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                comboBoxDepartment.Text = row.Cells["Department"].Value.ToString();

                if (row.Cells["HireDate"].Value != DBNull.Value)
                {
                    dtpHireDate.Value = Convert.ToDateTime(row.Cells["HireDate"].Value);
                }
                else
                {
                    dtpHireDate.Value = DateTime.Now; // Or set a default value  
                }

                txtSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }
    }
}
