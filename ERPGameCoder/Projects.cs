using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class Projects : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Projects()
        {
            InitializeComponent();
            LoadProjects();
            LoadLeadDesigners();
        }

        private void LoadProjects()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ProjectId, Name, StartDate, EndDate, Budget, Genre, Platform, GameEngine, ReleaseDate, LeadDesignerId FROM Projects";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridViewProjects.DataSource = table;
            }
        }

        private void LoadLeadDesigners()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT EmployeeId, Name FROM Employees";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbLeadDesigner.DataSource = table;
                cmbLeadDesigner.DisplayMember = "Name";
                cmbLeadDesigner.ValueMember = "EmployeeId";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Projects 
                                (Name, StartDate, EndDate, Budget, Genre, Platform, GameEngine, ReleaseDate, LeadDesignerId) 
                                VALUES 
                                (@Name, @StartDate, @EndDate, @Budget, @Genre, @Platform, @GameEngine, @ReleaseDate, @LeadDesignerId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", txtProjectName.Text);
                command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                command.Parameters.AddWithValue("@Budget", Convert.ToDecimal(txtBudget.Text));
                command.Parameters.AddWithValue("@Genre", txtGenre.Text);
                command.Parameters.AddWithValue("@Platform", txtPlatform.Text);
                command.Parameters.AddWithValue("@GameEngine", txtGameEngine.Text);
                command.Parameters.AddWithValue("@ReleaseDate", dtpReleaseDate.Value);
                command.Parameters.AddWithValue("@LeadDesignerId", cmbLeadDesigner.SelectedValue ?? DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadProjects();
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells["ProjectId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Projects 
                                    SET Name = @Name, StartDate = @StartDate, EndDate = @EndDate, Budget = @Budget, 
                                        Genre = @Genre, Platform = @Platform, GameEngine = @GameEngine, 
                                        ReleaseDate = @ReleaseDate, LeadDesignerId = @LeadDesignerId 
                                    WHERE ProjectId = @ProjectId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", txtProjectName.Text);
                    command.Parameters.AddWithValue("@StartDate", dtpStartDate.Value);
                    command.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);
                    command.Parameters.AddWithValue("@Budget", Convert.ToDecimal(txtBudget.Text));
                    command.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    command.Parameters.AddWithValue("@Platform", txtPlatform.Text);
                    command.Parameters.AddWithValue("@GameEngine", txtGameEngine.Text);
                    command.Parameters.AddWithValue("@ReleaseDate", dtpReleaseDate.Value);
                    command.Parameters.AddWithValue("@LeadDesignerId", cmbLeadDesigner.SelectedValue ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ProjectId", projectId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadProjects();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a project to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                int projectId = Convert.ToInt32(dataGridViewProjects.SelectedRows[0].Cells["ProjectId"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Projects WHERE ProjectId = @ProjectId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProjectId", projectId);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadProjects();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a project to delete.");
            }
        }

        private void ClearFields()
        {
            txtProjectName.Clear();
            txtBudget.Clear();
            txtGenre.Clear();
            txtPlatform.Clear();
            txtGameEngine.Clear();
            cmbLeadDesigner.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            dtpReleaseDate.Value = DateTime.Now;
        }

        private void dataGridViewProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProjects.Rows[e.RowIndex];
                txtProjectName.Text = row.Cells["Name"].Value.ToString();
                txtBudget.Text = row.Cells["Budget"].Value.ToString();
                txtGenre.Text = row.Cells["Genre"].Value.ToString();
                txtPlatform.Text = row.Cells["Platform"].Value.ToString();
                txtGameEngine.Text = row.Cells["GameEngine"].Value.ToString();
                cmbLeadDesigner.SelectedValue = row.Cells["LeadDesignerId"].Value ?? DBNull.Value;
                dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dtpEndDate.Value = row.Cells["EndDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["EndDate"].Value);
                dtpReleaseDate.Value = row.Cells["ReleaseDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["ReleaseDate"].Value);
            }
        }
    }
}

