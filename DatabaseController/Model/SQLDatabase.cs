using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseController.Model
{
    public class SQLDatabase
    {
        private string login;
        private string password;
        private MySqlConnectionStringBuilder connStrBuilder;
        private MySqlConnection connection;
        

        public SQLDatabase(string login, string password)
        {
            this.login = login;
            this.password = password;
            connStrBuilder = new MySqlConnectionStringBuilder();

            try
            {
                connStrBuilder.UserID = this.login;
                connStrBuilder.Password = this.password;
                connStrBuilder.Server = "localhost";
                connStrBuilder.Database = "main.sql";
                connStrBuilder.Port = 3306;

                connection = new MySqlConnection(connStrBuilder.ToString());
                connection.Open();
            }
            catch (Exception e) { Debug.WriteLine("Cannot open the database!"); }
        }

        public string Login { get => login; }
        public MySqlConnectionStringBuilder ConnStrBuillder { get => connStrBuilder; }
        public MySqlConnection Connection { get => connection; }
    }
}
