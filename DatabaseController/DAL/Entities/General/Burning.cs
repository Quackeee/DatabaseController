using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Entities
{
    public class Burning : Entity
    {
        public uint IdR { get; private set; }
        public string Name { get; private set; }
        public uint IdZ { get; private set; }
        public string Level { get; private set; }
        public string Treatment { get; private set; }
        public DateTime Date { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            IdR = uint.Parse(dataReader["id_r"].ToString());
            Name = dataReader["nazwa_palarni"].ToString();
            IdZ = uint.Parse(dataReader["id_z"].ToString());
            Level = dataReader["stopien"].ToString();
            Treatment = dataReader["obrobka"].ToString();
            Date = DateTime.Parse(dataReader["data"].ToString());
        }
    }
}
