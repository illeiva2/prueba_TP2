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
    public partial class VentanaPrincipal : Form
    {
        private Conexion mConexion; // Conexion recibida del formulario Login
        
        // CConstructor que recibe la instancia de Conexion
        public VentanaPrincipal(Conexion conexion)
        {
            InitializeComponent();
            mConexion = conexion; // asigno la conexion existente
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            // Creamos una instancia del formulario de Incripcion
            InscripcionSocio formInscripcion = new InscripcionSocio(mConexion);

            // Mostramos el formulario de inscripción
            formInscripcion.Show();
        }
    }
}
