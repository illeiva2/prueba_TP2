using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace FormsPildorasInformaticas
{
    public partial class Form1 : Form
    {
        private Conexion mConexion;

        public Form1()
        {
            InitializeComponent();
            mConexion = Conexion.GetInstance(); // Obtener la instancia de conexión singleton
            // Configuramos para que la contraseña se oculte siempre
            txtPassword.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Código para mostrar la contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void lblContrasenia_Click(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contrasenia = txtPassword.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Los campos de usuario y contraseña son obligatorios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamamos a la función para validar los datos
            if (ValidarCredenciales(nombreUsuario, contrasenia))
            {
                // Si las credenciales son válidas, abrimos el formulario principal.
                VentanaPrincipal formPrincipal = new VentanaPrincipal(mConexion);
                formPrincipal.Show();

                // Cerramos el form de Login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private bool ValidarCredenciales(string nombreUsuario, string contrasenia)
        {
            using (MySqlCommand comando = new MySqlCommand())
            {
                try
                {
                    comando.Connection = mConexion.GetConexion();
                    comando.CommandText = "SELECT * FROM usuario WHERE NombreUsuario = @nombreUsuario AND PassUsuario = @contrasenia";

                    // Parámetros para prevenir inyecciones SQL
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        // Si hay resultados, las credenciales son válidas
                        return reader.HasRows;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    return false;
                }
                // La conexión no se cierra aquí, ya que el método GetConexion() devuelve la conexión activa
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
    }
}
