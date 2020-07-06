using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Package : Entity
    {
        public uint IdP { get; private set; }
        public uint IdR { get; private set; }
        public double Waga { get; private set; }
        public double Cena { get; private set; }
        public uint Liczba { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {
            IdP = uint.Parse(dataReader["id_p"].ToString());
            IdR = uint.Parse(dataReader["id_r"].ToString());
            Waga = double.Parse(dataReader["waga"].ToString());
            Cena = double.Parse(dataReader["cena"].ToString());
            Liczba = uint.Parse(dataReader["liczba"].ToString());
        }
    }
}
