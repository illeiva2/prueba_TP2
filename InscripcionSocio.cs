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

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(documento) ||
                string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios");
                return;
            }

            MySqlConnection connection = null; // Inicializamos la conexión

            try
            {
                // Obtener la conexión singleton
                connection = Conexion.GetInstance().GetConexion();

                using (MySqlCommand cmdNuevoCliente = new MySqlCommand("NuevoCliente", connection))
                {
                    cmdNuevoCliente.CommandType = CommandType.StoredProcedure;

                    cmdNuevoCliente.Parameters.AddWithValue("@Nom", nombre);
                    cmdNuevoCliente.Parameters.AddWithValue("@Ape", apellido);
                    cmdNuevoCliente.Parameters.AddWithValue("@Doc", documento);
                    cmdNuevoCliente.Parameters.AddWithValue("@Email", email);
                    cmdNuevoCliente.Parameters.AddWithValue("@Telefono", telefono);

                    MySqlParameter rtaParameter = new MySqlParameter("@rta", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmdNuevoCliente.Parameters.Add(rtaParameter);

                    cmdNuevoCliente.ExecuteNonQuery();

                    int resultado = Convert.ToInt32(rtaParameter.Value);

                    if (resultado == 1)
                    {
                        MessageBox.Show("El cliente se ha registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con este DNI");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                // Aseguramos el cierre de la conexión
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
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
