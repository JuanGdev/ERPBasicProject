using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class Tasks : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Tasks()
        {
            InitializeComponent();
            LoadTasks();
            LoadEmployees();
            LoadProjects();
        }

        private void LoadTasks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tasks";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewTasks.DataSource = table;
            }
        }

        private void LoadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeId, Name FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbEmployee.DataSource = table;
                cmbEmployee.DisplayMember = "Name";
                cmbEmployee.ValueMember = "EmployeeId";
            }
        }

        private void LoadProjects()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ProjectId, Name FROM Projects";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbProject.DataSource = table;
                cmbProject.DisplayMember = "Name";
                cmbProject.ValueMember = "ProjectId";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Tasks (Name, Description, EmployeeId, ProjectId, DueDate, Status, TaskType, Priority, EstimatedHours, ActualHours, Dependencies) 
                                 VALUES (@Name, @Description, @EmployeeId, @ProjectId, @DueDate, @Status, @TaskType, @Priority, @EstimatedHours, @ActualHours, @Dependencies)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtTaskName.Text);
                command.Parameters.AddWithValue("@Description", txtDescription.Text);
                command.Parameters.AddWithValue("@EmployeeId", cmbEmployee.SelectedValue);
                command.Parameters.AddWithValue("@ProjectId", cmbProject.SelectedValue);
                command.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                command.Parameters.AddWithValue("@Status", cmbStatus.Text);
                command.Parameters.AddWithValue("@TaskType", cmbTaskType.Text);
                command.Parameters.AddWithValue("@Priority", cmbPriority.Text);
                command.Parameters.AddWithValue("@EstimatedHours", numEstimatedHours.Value);
                command.Parameters.AddWithValue("@ActualHours", numActualHours.Value);
                command.Parameters.AddWithValue("@Dependencies", txtDependencies.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadTasks();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["TaskId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Tasks 
                                     SET Name = @Name, Description = @Description, EmployeeId = @EmployeeId, ProjectId = @ProjectId, 
                                         DueDate = @DueDate, Status = @Status, TaskType = @TaskType, Priority = @Priority, 
                                         EstimatedHours = @EstimatedHours, ActualHours = @ActualHours, Dependencies = @Dependencies 
                                     WHERE TaskId = @TaskId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", txtTaskName.Text);
                    command.Parameters.AddWithValue("@Description", txtDescription.Text);
                    command.Parameters.AddWithValue("@EmployeeId", cmbEmployee.SelectedValue);
                    command.Parameters.AddWithValue("@ProjectId", cmbProject.SelectedValue);
                    command.Parameters.AddWithValue("@DueDate", dtpDueDate.Value);
                    command.Parameters.AddWithValue("@Status", cmbStatus.Text);
                    command.Parameters.AddWithValue("@TaskType", cmbTaskType.Text);
                    command.Parameters.AddWithValue("@Priority", cmbPriority.Text);
                    command.Parameters.AddWithValue("@EstimatedHours", numEstimatedHours.Value);
                    command.Parameters.AddWithValue("@ActualHours", numActualHours.Value);
                    command.Parameters.AddWithValue("@Dependencies", txtDependencies.Text);
                    command.Parameters.AddWithValue("@TaskId", taskId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadTasks();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count > 0)
            {
                int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells["TaskId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Tasks WHERE TaskId = @TaskId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TaskId", taskId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadTasks();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void ClearFields()
        {
            txtTaskName.Clear();
            txtDescription.Clear();
            cmbEmployee.SelectedIndex = -1;
            cmbProject.SelectedIndex = -1;
            dtpDueDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
            cmbTaskType.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
            numEstimatedHours.Value = 0;
            numActualHours.Value = 0;
            txtDependencies.Clear();
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTasks.Rows[e.RowIndex];
                txtTaskName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                cmbEmployee.SelectedValue = row.Cells["EmployeeId"].Value;
                cmbProject.SelectedValue = row.Cells["ProjectId"].Value;
                if (row.Cells["DueDate"].Value != DBNull.Value && row.Cells["DueDate"].Value != null)
                {
                    dtpDueDate.Value = Convert.ToDateTime(row.Cells["DueDate"].Value);
                }
                else
                {
                    dtpDueDate.Value = DateTime.Now; // Or set a default value
                }
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
                cmbTaskType.Text = row.Cells["TaskType"].Value.ToString();
                cmbPriority.Text = row.Cells["Priority"].Value.ToString();

                numEstimatedHours.Value = row.Cells["EstimatedHours"].Value != DBNull.Value
                    ? Convert.ToDecimal(row.Cells["EstimatedHours"].Value)
                    : 0;
                numActualHours.Value = row.Cells["ActualHours"].Value != DBNull.Value
                    ? Convert.ToDecimal(row.Cells["ActualHours"].Value)
                    : 0;
                txtDependencies.Text = row.Cells["Dependencies"].Value.ToString();
            }
        }
    }
}
