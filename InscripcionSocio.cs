using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsPildorasInformaticas
{
    public partial class InscripcionSocio : Form
    {
        private Conexion mConexion;
        public InscripcionSocio(Conexion conexion)
        {
            InitializeComponent();
            mConexion = conexion;
        }

        private void InscripcionSocio_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptarSocio_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreS.Text;
            string apellido = txtApellidoS.Text;
            string documento = txtDniS.Text;
            string direccion = txtDireS.Text;
            string telefono = txtTelS.Text;
            string email = txtEmailS.Text;

            // verificamos que los campos requeridos no esten vacios

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(documento) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor complete los campos obligatorios");
                return;
            }

            try
            {
                if (mConexion.GetConexion().State != System.Data.ConnectionState.Open)
                {
                    mConexion.GetConexion().Open();
                }

                // Comprobacion de existencia de socio usando el DNI
                string queryCheck = "SELECT COUNT(*) FROM SOCIO WHERE DNI = @documento";
                MySqlCommand cmdCheck = new MySqlCommand(queryCheck, mConexion.GetConexion());
                cmdCheck.Parameters.AddWithValue("@documento", documento);

                int contadorDni = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (contadorDni > 0)
                {
                    MessageBox.Show("Ya existe un socio con este DNI");
                    return;
                }


                // Consulta SQL con parametros para insertar los datos en la tabla Socio
                string query = "INSERT INTO socio (Nombre, Apellido, DNI, Direccion, Telefono, Email)" +
                    "VALUES (@nombre, @apellido, @documento,@direccion, @telefono, @email)";
                MySqlCommand cmd = new MySqlCommand(query, mConexion.GetConexion());

                //Asignamos valores a los parametros
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@email", email);

                // Ejecutamos la consulta
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("El socio se ha registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar socio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos" + ex.Message);
            }

            finally
            {
                if (mConexion.GetConexion().State == System.Data.ConnectionState.Open)
                {
                    mConexion.GetConexion().Close();
                }
            }

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            // Recorremos todos los controles del formulario

            foreach (Control control in this.Controls)
            {
                // si el control es un textbox lo limpiamos
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }

        private void btnCancelarI_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
