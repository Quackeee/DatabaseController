using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.DAL.Entities
{
    public abstract class Entity
    {
        public abstract void LoadFromReader(MySqlDataReader dataReader);
    }
}
