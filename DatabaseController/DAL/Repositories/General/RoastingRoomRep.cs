using DatabaseController.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class RoastingRoomRep
    {
        private const string ALL_ROASTING_ROOMS = "SELECT * FROM palarnia";

        public static List<RoastingRoom> GetAllRoastingRooms()
        {
            List<RoastingRoom> roastingRooms = new List<RoastingRoom>();
            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(ALL_ROASTING_ROOMS, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                        roastingRooms.Add(new RoastingRoom(reader));
                    connection.Close();
                }
            }
            catch (Exception e) { }

            return roastingRooms;
        }
    }
}
