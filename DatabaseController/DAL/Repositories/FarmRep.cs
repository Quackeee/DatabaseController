using DatabaseController.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class FarmRep
    {
        private const string ALL_FARMS = "SELECT * FROM farma";


        public static List<Farm> GetAllFarms()
        {
            List<Farm> farms = new List<Farm>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_FARMS, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        farms.Add(new Farm(reader));
                    connection.Close();
                }
            }
            catch(Exception e) { }
            

            return farms;
        }
    }
}
