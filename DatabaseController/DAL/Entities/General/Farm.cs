using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Farm : Entity
    {
        public string Nazwa { get; private set; }
        public string Wlasciciel { get; private set; }
        public string Kraj { get; private set; }
        public string Region { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            Nazwa = dataReader["nazwa"].ToString();
            Wlasciciel = dataReader["wlasciciel"].ToString();
            Kraj = dataReader["kraj"].ToString();
            Region = dataReader["region"].ToString();
        }
    }
}
