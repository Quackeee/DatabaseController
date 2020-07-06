﻿using DatabaseController.DAL.Entities;
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
        public double Weight { get; private set; }
        public string Method { get; private set; }
        public string Speciality { get; private set; }
        public float Score { get; private set; }
        public string Cons { get; private set; }
        public string Body { get; private set; }
        public string Acidity { get; private set; }
        public string Sweetness { get; private set; }
        

        public override string ToString()
        {
            return ($"{IdR}, {Weight}, {Speciality}, {Cons}");
        }

        public override void LoadFromReader(MySqlDataReader dataReader)
        {

            IdR = uint.Parse(dataReader["id_r"].ToString());
            Weight = double.Parse(dataReader["waga"].ToString());
            Method = dataReader["zalecana_metoda"].ToString();
            Speciality = dataReader["jest_speciality"].ToString();
            Score = float.Parse(dataReader["punktacja"].ToString());
            Cons = dataReader["wady"].ToString();
            Body = dataReader["body"].ToString();
            Acidity = dataReader["kwasowosc"].ToString();
            Sweetness = dataReader["slodycz"].ToString();
        }
    }
}
