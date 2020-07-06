using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class RoastingRoom : Entity
    {
        public string Nazwa { get; private set; }
        public string Wlasciciel { get; private set; }
        public double Budzet { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            Nazwa = dataReader["nazwa"].ToString();
            Wlasciciel = dataReader["wlasciciel"].ToString();
            Budzet = double.Parse(dataReader["budzet"].ToString());
        }
    }
}
