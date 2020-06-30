using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Seed
    {
        private double weight;
        private double idZ;
        private double price;
        private double height;

        public Seed(double weight, double idZ, double price, double height)
        {
            this.weight = weight;
            this.idZ = idZ;
            this.price = price;
            this.height = height;
        }

        public double Weight { get => weight; }
        public double IDZ { get => idZ; }
        public double Price { get => price; }
        public double Height { get => height; }
    }
}
