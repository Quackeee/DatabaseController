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
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public double Budget { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            Name = dataReader["nazwa"].ToString();
            Owner = dataReader["wlasciciel"].ToString();
            Budget = double.Parse(dataReader["budzet"].ToString());
        }
    }
}
