using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    public class Roasted
    {
        private double idR;
        private double weight;
        private string recomendedMethod;
        private bool isSpeciality;
        private double score;
        private string cons;
        private string body;
        private string acidity;
        private string sweetness;

        public Roasted(double idR, double weight, string recomendedMethod, bool isSpeciality, double score,
                       string cons, string body, string acidity, string sweetness)
        {
            this.idR = idR;
            this.weight = weight;
            this.recomendedMethod = recomendedMethod;
            this.isSpeciality = isSpeciality;
            this.score = score;
            this.cons = cons;
            this.body = body;
            this.acidity = acidity;
            this.sweetness = sweetness;
        }

        public double IdR { get => idR; }
        public double Weight { get => weight; }
        public string RecomendedMethod { get => recomendedMethod; }
        public bool IsSpeciality { get => isSpeciality; }
        public double Score { get => score; }
        public string Cons { get => cons; }
        public string Body { get => body; }
        public string Acidity { get => acidity; }
        public string Sweetness { get => sweetness; }
    }
}
