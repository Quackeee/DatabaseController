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
        public string Name { get; private set; }
        public double Budget { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            Name = dataReader["nazwa"].ToString();
            Budget = double.Parse(dataReader["budzet"].ToString());
        }
    }
}
