using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL
{
    class DBConnection
    {
        public static string UserID { get; private set; }
        private static string Password { get; set; }
        
        private MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
        
        private static DBConnection instance = null;
        public static DBConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnection();
                return instance;
            }
        }

        public MySqlConnection Connection => new MySqlConnection(stringBuilder.ToString());

        private DBConnection()
        {
            stringBuilder.UserID = "root";
            stringBuilder.Password = "Zaq12wsx";
            stringBuilder.Server = "localhost";
            stringBuilder.Database = "roaster";
            stringBuilder.Port = 3306;
        }

        public static void LogIn(string userId, string password)
        {
            UserID = userId;
            Password = password;
        }
    }
}
