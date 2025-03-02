﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            Instance.stringBuilder.UserID = userId;
            Instance.stringBuilder.Password = password;
        }

        public static string GetUserRole()
        {
            string role = string.Empty;

            using (var connection = Instance.Connection)
            {
                connection.Open();

                if (Instance.stringBuilder.UserID == "root") return "root";
                MySqlCommand command = new MySqlCommand("select current_role()", connection);

                
                var reader = command.ExecuteReader();
                reader.Read();
                role = reader.GetString(0).Trim('`', '%', '@');
                Debug.WriteLine(role);
                connection.Close();
            }

            return role;
        }

        public static string TryExecuteCommand(string commandString)
        {
            using (var connection = Instance.Connection)
            {
                try
                {
                    connection.Open();
                    Debug.WriteLine(commandString);
                    int affected = new MySqlCommand(commandString, connection).ExecuteNonQuery();
                    connection.Close();
                    return $"Query OK: {affected} rows affected.";
                } catch (Exception e) { return e.Message; }
            }
        }

        public static void ExecuteCommand(string commandString)
        {
            using (var connection = Instance.Connection)
            {
                connection.Open();
                Debug.WriteLine(commandString);
                int affected = new MySqlCommand(commandString, connection).ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
