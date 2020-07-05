using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Farm
    {
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public string Country { get; private set; }
        public string Region { get; private set; }

        public Farm(MySqlDataReader dataReader)
        {
            Name = dataReader["nazwa"].ToString();
            Owner = dataReader["wlasciciel"].ToString();
            Country = dataReader["kraj"].ToString();
            Region = dataReader["region"].ToString();
        }
    }
}
