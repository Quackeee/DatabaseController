using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Seed
    {
        public uint IdZ { get; private set; }
        public double Weight { get; private set; }
        public double Price { get; private set; }
        public int Height { get; private set; }

        public Seed(MySqlDataReader dataReader)
        {
            IdZ = uint.Parse(dataReader["id_z"].ToString());
            Weight = double.Parse(dataReader["waga"].ToString());
            Price = double.Parse(dataReader["cena"].ToString());
            Height = int.Parse(dataReader["wysokosc_upraw"].ToString());
        }
    }
}
