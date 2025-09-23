using MySql.Data.MySqlClient;

namespace Futbol.Database
{
    public class Db
    {
        private const string connString = "server=localhost;database=futbol;uid=abd;pwd=abd;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}