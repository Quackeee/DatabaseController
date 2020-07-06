using DatabaseController.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class SeedRep
    {
        private const string ALL_SEEDS = "SELECT * FROM ziarna";

        public static List<Seed> GetAllSeeds()
        {
            List<Seed> seeds = new List<Seed>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_SEEDS, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        seeds.Add(new Seed(reader));
                    connection.Close();
                }
            }
            catch(Exception e) { }

            return seeds;
        }
    }
}
