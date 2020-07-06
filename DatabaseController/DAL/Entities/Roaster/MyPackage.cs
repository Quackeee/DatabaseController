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
        public string Kraj { get; private set; }
        public string Region { get; private set; }
        public double Waga { get; private set; }
        public double Cena { get; private set; }
        public uint Liczba { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            ID = uint.Parse(dataReader["ID"].ToString());
            Kraj = dataReader["kraj"].ToString();
            Region = dataReader["region"].ToString();
            Waga = double.Parse(dataReader["waga"].ToString());
            Cena = double.Parse(dataReader["cena"].ToString());
            Liczba = uint.Parse(dataReader["liczba"].ToString());
        }
    }
}
