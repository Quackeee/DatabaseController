using DatabaseController.DAL.Entities;
using DatabaseController.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL
{
    abstract class DBModel
    {
        public static ObservableCollection<T> GetAllDBObjects<T>(string commandString) where T : Entity, new()
        {
            var objects = new ObservableCollection<T>();

            try
            {
                using (var connection = DBConnection.Instance.Connection)
                {
                    MySqlCommand command = new MySqlCommand(commandString, connection);

                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var toAdd = new T();
                        toAdd.LoadFromReader(reader);
                        objects.Add(toAdd);
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Unable to load objects: {e.Message}");
            }

            return objects;
        }
    }
}
