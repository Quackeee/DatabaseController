using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace DatabaseController.Model
{
    public class SQLDatabase
    {
        private string login;
        private string password;
        private MySqlConnectionStringBuilder connStrBuilder;
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader dataReader;
        private MySqlDataAdapter dataAdapter;

        private List<Farm> farms;
        private List<Package> packages;
        private List<Roasted> roasteds;
        private List<RoastingRoom> roastingRooms;
        private List<Seed> seeds;
        

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
                connStrBuilder.Database = "roaster";
                connStrBuilder.Port = 3306;

                connection = new MySqlConnection(connStrBuilder.ToString());
                connection.Open();
                System.Windows.MessageBox.Show("Connection succeed!");
            }
            catch (Exception e) { System.Windows.MessageBox.Show(e.Message.ToString()); }
        }
        
        public List<Farm> GetFarms()
        {
            connection.Open();
            command = new MySqlCommand("SELECT * FROM farma", connection);
            dataReader = command.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    farms.Add(
                        new Farm(dataReader["nazwa"].ToString(),
                                 dataReader["wlasciciel"].ToString(),
                                 dataReader["kraj"].ToString(),
                                 dataReader["region"].ToString()));
                }
            }
            else
                farms = null;

            connection.Close();
            return farms;
        }


        public MySqlConnection Connection { get => connection; set { connection = value; } }
        public MySqlCommand Command { get => command; set { command = value; } }
        public MySqlDataAdapter DataAdapter { get => dataAdapter; set { dataAdapter = value; } }
    }
}
