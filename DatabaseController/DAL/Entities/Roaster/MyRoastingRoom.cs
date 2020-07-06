using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Entities.Roaster
{
    public class MyRoastingRoom : Entity
    {
        public string Nazwa { get; private set; }
        public double Budzet { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            Nazwa = dataReader["nazwa"].ToString();
            Budzet = double.Parse(dataReader["budzet"].ToString());
        }
    }
}
