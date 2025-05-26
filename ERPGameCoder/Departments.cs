using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class Departments : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Departments()
        {
            InitializeComponent();
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DepartmentId, Name FROM Departments";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewDepartments.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Departments (Name) VALUES (@Name)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtDepartmentName.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadDepartments();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartments.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridViewDepartments.SelectedRows[0].Cells["DepartmentId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Departments SET Name = @Name WHERE DepartmentId = @DepartmentId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", txtDepartmentName.Text);
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadDepartments();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a department to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartments.SelectedRows.Count > 0)
            {
                int departmentId = Convert.ToInt32(dataGridViewDepartments.SelectedRows[0].Cells["DepartmentId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Departments WHERE DepartmentId = @DepartmentId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DepartmentId", departmentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadDepartments();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a department to delete.");
            }
        }

        private void ClearFields()
        {
            txtDepartmentName.Clear();
        }

        private void dataGridViewDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDepartments.Rows[e.RowIndex];
                txtDepartmentName.Text = row.Cells["Name"].Value.ToString();
            }
        }
    }
}
