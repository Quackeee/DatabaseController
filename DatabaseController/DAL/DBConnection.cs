using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL
{
    class DBConnection
    {
        public static string UserID { get; private set; }
        private static string Password { get; set; }
        
        public MySqlConnectionStringBuilder stringBuilder;
        
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
            stringBuilder = new MySqlConnectionStringBuilder();


            stringBuilder.UserID = UserID;
            stringBuilder.Password = Password;
            stringBuilder.Server = "localhost";
            stringBuilder.Database = "roaster";
            stringBuilder.Port = 3306;
        }

        public static void LogIn(string userId, string password)
        {
            UserID = userId;
            Password = password;
        }

        public static void LogOut()
        {
            instance = null;
        }

        public static string GetUserRole()
        {
            if (UserID == "root") return "root";
            string role = string.Empty;

            using (var connection = Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand("select current_role()", connection);
                connection.Open();
                var reader = command.ExecuteReader();
                reader.Read();
                role = reader.GetString(0).Trim('`','%','@');
                Debug.WriteLine(role);
                connection.Close();
            }

            return role;
        }
    }
}
