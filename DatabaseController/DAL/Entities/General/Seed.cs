using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Ziarna : Entity
    {
        public uint IdZ { get; private set; }
        public double Waga { get; private set; }
        public double Cena { get; private set; }
        public int Wysokosc_upraw { get; private set; }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {

            IdZ = uint.Parse(dataReader["id_z"].ToString());
            Waga = double.Parse(dataReader["waga"].ToString());
            Cena = double.Parse(dataReader["cena"].ToString());
            Wysokosc_upraw = int.Parse(dataReader["wysokosc_upraw"].ToString());
        }
    }
}
