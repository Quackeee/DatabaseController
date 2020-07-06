using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static void ExecuteCommand(string commandString)
        {
            using (var connection = Instance.Connection)
            {
                try
                {
                    connection.Open();
                    Debug.WriteLine(commandString);
                    int affected = new MySqlCommand(commandString, connection).ExecuteNonQuery();
                    connection.Close();
                    Debug.WriteLine($"Query OK: {affected} rows affected.");
                } catch (Exception e) { Debug.WriteLine(e.Message); }
            }
        }
    }
}
