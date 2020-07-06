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
        public string Nazwa_farmy { get; private set; }
        public DateTime Data { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {

            IdZ = uint.Parse(dataReader["id_z"].ToString());
            Nazwa_farmy = dataReader["nazwa_farmy"].ToString();
            Data = DateTime.Parse(dataReader["data"].ToString());
        }
    }
}
