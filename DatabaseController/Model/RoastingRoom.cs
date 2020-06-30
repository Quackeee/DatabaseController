using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class RoastingRoom
    {
        private string name;
        private string owner;
        private double budget;

        public RoastingRoom(string name, string owner, double budget)
        {
            this.name = name;
            this.owner = owner;
            this.budget = budget;
        }

        public string Name { get => name; }
        public string Owner { get => owner; }
        public double Budget { get=> budget; }
    }
}
