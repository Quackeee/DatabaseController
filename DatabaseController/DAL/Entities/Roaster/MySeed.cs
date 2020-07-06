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
        public string Kraj { get; private set; }
        public string Region { get; private set; }
        public DateTime Data { get; private set; }
        public double Waga { get; private set; }
        public string Jest_speciality { get; private set; }
        public float Punktacja { get; private set; }
        public string Kwasowosc { get; private set; }
        public string Slodycz { get; private set; }
        public string Wady { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            ID = uint.Parse(dataReader["ID"].ToString());
            Kraj = dataReader["kraj"].ToString();
            Region = dataReader["region"].ToString();
            Data = DateTime.Parse(dataReader["data palenia"].ToString());
            Waga = double.Parse(dataReader["waga"].ToString());
            Jest_speciality = dataReader["speciality"].ToString();
            Punktacja = float.Parse(dataReader["punktacja"].ToString());
            Kwasowosc = dataReader["kwasowosc"].ToString();
            Slodycz = dataReader["slodycz"].ToString();
            Wady = dataReader["wady"].ToString();
        }
    }
}
