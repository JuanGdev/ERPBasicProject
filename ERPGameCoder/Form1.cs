using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERPGameCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string email = tb_usuarioId.Text; // Correo electrónico
            string password = tb_password.Text; // Contraseña

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingresa el correo electrónico y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cadena de conexión desde App.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Consulta SQL para validar el usuario y la contraseña
            string query = @"
                SELECT UserType 
                FROM Users 
                WHERE Email = @Email AND UserId  = @UserId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@UserId", password);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        string userType = result.ToString();

                        MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrir FormEmployees
                        FormEmployees formEmployees = new FormEmployees();

                        // Configurar acceso según el tipo de usuario
                        if (userType == "Admin")
                        {
                          //  formEmployees.EnableAdminFeatures(); // Método para habilitar funciones de administrador
                        }
                        else if (userType == "User")
                        {
                         //   formEmployees.DisableAdminFeatures(); // Método para deshabilitar funciones de administrador
                        }

                        formEmployees.Show();

                        // Ocultar el formulario actual
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Correo o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
