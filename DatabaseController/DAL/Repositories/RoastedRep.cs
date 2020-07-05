using DatabaseController.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class RoastedRep
    {
        private const string ALL_ROASTED = "SELECT * FROM wypalone";


        public static List<Roasted> GetAllRoasted()
        {
            List<Roasted> roasted = new List<Roasted>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(ALL_ROASTED, connection);

                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    roasted.Add(new Roasted(reader));
                connection.Close();
            }

            return roasted;
        }
    }
}
