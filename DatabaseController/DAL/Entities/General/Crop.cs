using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Entities
{
    public class Crop : Entity
    {
        public uint IdZ { get; private set; }
        public string FarmName { get; private set; }
        public DateTime Date { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {

            IdZ = uint.Parse(dataReader["id_z"].ToString());
            FarmName = dataReader["nazwa_farmy"].ToString();
            Date = DateTime.Parse(dataReader["data"].ToString());
        }
    }
}
