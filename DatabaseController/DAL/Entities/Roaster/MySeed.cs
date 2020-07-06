using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Entities.Roaster
{
    public class MySeed : Entity
    {
        public uint ID { get; private set; }
        public string Country { get; private set; }
        public string Region { get; private set; }
        public DateTime Date { get; private set; }
        public double Weight { get; private set; }
        public string Speciality { get; private set; }
        public float Score { get; private set; }
        public string Acidity { get; private set; }
        public string Sweetness { get; private set; }
        public string Cons { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            ID = uint.Parse(dataReader["ID"].ToString());
            Country = dataReader["kraj"].ToString();
            Region = dataReader["region"].ToString();
            Date = DateTime.Parse(dataReader["data palenia"].ToString());
            Weight = double.Parse(dataReader["waga"].ToString());
            Speciality = dataReader["speciality"].ToString();
            Score = float.Parse(dataReader["punktacja"].ToString());
            Acidity = dataReader["kwasowosc"].ToString();
            Sweetness = dataReader["slodycz"].ToString();
            Cons = dataReader["wady"].ToString();
        }
    }
}
