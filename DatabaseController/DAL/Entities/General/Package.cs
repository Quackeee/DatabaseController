using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Package : Entity
    {
        public uint IdP { get; private set; }
        public uint IdR { get; private set; }
        public double Weight { get; private set; }
        public double Price { get; private set; }
        public uint Count { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            IdP = uint.Parse(dataReader["id_p"].ToString());
            IdR = uint.Parse(dataReader["id_r"].ToString());
            Weight = double.Parse(dataReader["waga"].ToString());
            Price = double.Parse(dataReader["cena"].ToString());
            Count = uint.Parse(dataReader["liczba"].ToString());
        }
    }
}
