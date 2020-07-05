﻿using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Repositories
{
    static class CropRep
    {
        private const string ALL_CROPS = "SELECT * FROM zbior";


        public static List<Crop> GetAllCrops()
        {
            List<Crop> crops = new List<Crop>();
            using (var connection = DBConnection.Instance.Connection)
            {
                MySqlCommand command = new MySqlCommand(ALL_CROPS, connection);

                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                    farms.Add(new Crop(reader));
                connection.Close();
            }

            return crops;
        }
    }
}
