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
        public string Nazwa_palarni { get; private set; }
        public uint IdZ { get; private set; }
        public string Stopien { get; private set; }
        public string Obrobka { get; private set; }
        public DateTime Data { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            IdR = uint.Parse(dataReader["id_r"].ToString());
            Nazwa_palarni = dataReader["nazwa_palarni"].ToString();
            IdZ = uint.Parse(dataReader["id_z"].ToString());
            Stopien = dataReader["stopien"].ToString();
            Obrobka = dataReader["obrobka"].ToString();
            Data = DateTime.Parse(dataReader["data"].ToString());
        }
    }
}
