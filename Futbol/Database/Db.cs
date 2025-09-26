using MySql.Data.MySqlClient;

namespace Futbol.Database
{
    public class Db
    {
        private const string connString = "server=localhost;database=ProgFutbol;uid=user1_abd;pwd=abd1;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connString);
        }
    }
}