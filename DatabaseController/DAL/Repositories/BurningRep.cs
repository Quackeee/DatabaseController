using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class BurningRep
    {
        private const string ALL_BURNINGS = "SELECT * FROM palenie";


        public static List<Burning> GetAllBurnings()
        {
            List<Burning> burnings = new List<Burning>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_BURNINGS, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        burnings.Add(new Burning(reader));
                    connection.Close();
                }
            }
            catch (Exception e) { }

            return burnings;
        }
    }
}
