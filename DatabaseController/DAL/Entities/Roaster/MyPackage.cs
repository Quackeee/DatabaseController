using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Entities.Roaster
{
    public class MyPackage : Entity
    {
        public uint ID { get; private set; }
        public string Country { get; private set; }
        public string Region { get; private set; }
        public double Weight { get; private set; }
        public double Price { get; private set; }
        public uint Count { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            ID = uint.Parse(dataReader["ID"].ToString());
            Country = dataReader["kraj"].ToString();
            Region = dataReader["region"].ToString();
            Weight = double.Parse(dataReader["waga"].ToString());
            Price = double.Parse(dataReader["cena"].ToString());
            Count = uint.Parse(dataReader["liczba"].ToString());
        }
    }
}
