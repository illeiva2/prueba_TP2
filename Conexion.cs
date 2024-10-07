using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPildorasInformaticas
{
    public class Conexion
    {
        private static Conexion instance;
        private MySqlConnection connection;

        private Conexion()
        {
            string connectionString = "server=localhost;database=clubdeportivo;uid=root;pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        public static Conexion GetInstance()
        {
            if (instance == null)
            {
                instance = new Conexion();
            }
            return instance;
        }

        public MySqlConnection GetConexion()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open(); // Abrir la conexión solo si no está abierta
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close(); // Cerrar la conexión solo si está abierta
            }
        }
    }
}