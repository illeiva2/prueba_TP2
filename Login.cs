using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace FormsPildorasInformaticas
{
    public partial class Form1 : Form
    {

        private Conexion mConexion;


        public Form1()
        {
            InitializeComponent();
            mConexion = new Conexion();
            // Configuramos para que la contraseña se oculte siempre
            txtPassword.UseSystemPasswordChar = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Codigo para mostrar la contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblContrasenia_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           string nombreUsuario = txtUsuario.Text;
           string contrasenia = txtPassword.Text;

           if(string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Los campos de usuario y contraseñia son obligatorios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // LLamamos a la funcion para validar los datos
            if (ValidarCredenciales(nombreUsuario, contrasenia))
            { 
                // Si las credenciales son válidas, abrimos el formulario principal.

                VentanaPrincipal formPrincipal = new VentanaPrincipal(mConexion);
                formPrincipal.Show();

                //cerramos el form de Login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }


        }
        private bool ValidarCredenciales(string nombreUsuario, string contrasenia)
        {
            MySqlDataReader reader = null;

            try
            {
                string consulta = "SELECT * FROM usuario WHERE NombreUsuario = @nombreUsuario AND PassUsuario = @contrasenia";
                MySqlCommand comando = new MySqlCommand(consulta, mConexion.GetConexion());

                // Parametros para prevenir inyecciones SQL
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                reader = comando.ExecuteReader();

                // si hay resultados las credenciales son validas

                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al conectar con base de datos");
                return false;
            }
            finally
            {
                // Cerrar el Datareader y la conexion

                if (reader != null && !reader.IsClosed) 
                {
                    reader.Close();

                }
                if (mConexion.GetConexion().State == System.Data.ConnectionState.Open) 
                { 
                    mConexion.GetConexion().Close();
                }

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



