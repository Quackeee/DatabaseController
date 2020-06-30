using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Package
    {
        private double weight;
        private double idP;
        private double price;

        public Package(double weight, double idP, double price)
        {
            this.weight = weight;
            this.idP = idP;
            this.price = price;
        }

        public double Weight { get => weight; }
        public double IdP { get => idP; }
        public double Price { get => price; }
    }
}
