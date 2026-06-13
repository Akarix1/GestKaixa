using MySql.Data.MySqlClient;

namespace GestKaixa.Config
{
    public static class Database
    {
        // variables de conexion
        private static string ipServidor = "192.168.3.3";
        private static string bdd = "kaixa";
        private static string usuarioAdmin = "cashbox_app";
        private static string passwordAdmin = "app123";

        // cadena de conexion
        private static string cadenaConexion = "SERVER=" + ipServidor + ";DATABASE=" + bdd + ";USER=" + usuarioAdmin + ";PASSWORD=" + passwordAdmin + ";";

        // metodo para obtener la conexion a la base de datos
        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}