using MySql.Data.MySqlClient;

namespace Admin
{
    public class Db
    {
        public static void LogUserLogin()
        {
            MySqlConnection conn = new MySqlConnection($"server=localhost;port=3306;database=cc_housekeeping;uid=root;password=;");
            conn.Open();

        }
    }
}
