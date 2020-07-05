using DatabaseController.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class PackageRep
    {
        private const string ALL_PACKAGES = "SELECT * FROM paczka";

        public static List<Package> GetAllPackages()
        {
            List<Package> packages = new List<Package>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_PACKAGES, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        packages.Add(new Package(reader));
                    connection.Close();
                }
            }
            catch(Exception e) { }

            return packages;
        }
    }
}
