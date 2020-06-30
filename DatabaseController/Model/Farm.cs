using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Farm
    {
        private string name;
        private string owner;
        private string country;
        private string region;

        public Farm(string name, string owner, string country, string region)
        {
            this.name = name;
            this.owner = owner;
            this.country = country;
            this.region = region;
        }

        public string Name { get => name; }
        public string Owner { get => owner; }
        public string Coutry { get => country; }
        public string Region { get => region; }
    }
}
