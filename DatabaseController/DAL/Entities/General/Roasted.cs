using DatabaseController.DAL.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseController.Model
{
    public class Roasted : Entity
    {
        public uint IdR { get; private set; }
        public double Waga { get; private set; }
        public string Zalecana_metoda { get; private set; }
        public string Jest_speciality { get; private set; }
        public float Punktacja { get; private set; }
        public string Wady { get; private set; }
        public string Body { get; private set; }
        public string Kwasowosc { get; private set; }
        public string Slodycz { get; private set; }
        
        public override void LoadFromReader(MySqlDataReader dataReader)
        {

            IdR = uint.Parse(dataReader["id_r"].ToString());
            Waga = double.Parse(dataReader["waga"].ToString());
            Zalecana_metoda = dataReader["zalecana_metoda"].ToString();
            Jest_speciality = dataReader["jest_speciality"].ToString();
            Punktacja = float.Parse(dataReader["punktacja"].ToString());
            Wady = dataReader["wady"].ToString();
            Body = dataReader["body"].ToString();
            Kwasowosc = dataReader["kwasowosc"].ToString();
            Slodycz = dataReader["slodycz"].ToString();
        }
    }
}
