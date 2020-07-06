using DatabaseController.CommandExecutors.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.CommandExecutors.ViewModel
{
    class RoastCommandExecutorVM : CommandFormVM
    {
        public int? Which { get; set; }
        public int? HowMuch { get; set; }
        public static string[] Methods { get; set; } = new string[] { "washed", "natural", "honey" };
        public string Method { get; set; }
        public static string[] Levels { get; set; } = new string[] { "jasne", "średnie", "ciemne" };
        public string Level { get; set; }
        public bool ForAeropress { get; set; }
        public bool ForDrip { get; set; }
        public bool ForChemex { get; set; }
        public bool ForPressureExpress { get; set; }
        public bool ForDripExpress { get; set; }
        public bool Speciality { get; set; }
        public int? Points { get; set; }
        public string Flaws { get; set; }
        public string Body { get; set; }
        public string Acidity { get; set; }
        public string Sweetness { get; set; }

        protected override string _generateCommandString()
        {

            var points = Points is null ? 0 : Points;
            var speciality = Speciality ? 1 : 0;

            string selectedMethods = "";

            void HandleSelectedMethodsEmpty(string s)
            {
                if (!string.IsNullOrEmpty(selectedMethods)) selectedMethods += "/";
                selectedMethods += s;
            }
            string HandleNull(string s)
            {
                return string.IsNullOrEmpty(s) ? "null" : $"'{s}'";
            }

            if (ForPressureExpress) selectedMethods += "ekspres ciśnieniowy";
            if (ForDripExpress) HandleSelectedMethodsEmpty("ekspres przelewowy");
            if (ForChemex) HandleSelectedMethodsEmpty("chemex");
            if (ForDrip) HandleSelectedMethodsEmpty("drip");
            if (ForAeropress) HandleSelectedMethodsEmpty("aeropress");

            return $"call wypal({Which}, {HowMuch}, '{Method}', '{Level}', {HandleNull(selectedMethods)},'{speciality}', " +
                $"{points}, {HandleNull(Flaws)}, {HandleNull(Body)}, {HandleNull(Acidity)}, {HandleNull(Sweetness)})";
        }
        public override bool CanExecuteCommand() =>
            Which > 0 && HowMuch > 0 && !(Method is null || Level is null) &&
            !(Speciality && Points < 80);

    }
}
