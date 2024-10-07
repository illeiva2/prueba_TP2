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
        // declaración de las variables que necesitamos para la conexion con la base de datos
        // pero creo que deberia ser con un constructor diferente para que cada uno pueda acceder en su compu
        private MySqlConnection? conexion;
        private string servidor = "localhost";
        private string puerto = "3306";
        private string database = "ClubDeportivo";
        private string usuario = "root";
        private string password = "rominagargano";
        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database +
                "; Datasource=" + servidor +
                "; port=" + puerto +
                "; User=" + usuario +
                "; Password=" + password;
        }
        public MySqlConnection GetConexion()
        { 
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                
            }
            return conexion;

            
        }
    }
}
