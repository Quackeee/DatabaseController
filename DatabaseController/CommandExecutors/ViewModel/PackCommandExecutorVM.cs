using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.CommandExecutors.ViewModel
{
    class PackCommandExecutorVM : CommandFormVM
    {
        public int? Which { get; set; }
        public double? Weight { get; set; }
        public int? Count { get; set; }
        public double? Price { get; set; }

        protected override string _generateCommandString() =>
            $"call pakuj({Which}, {Weight}, {Count}, {Math.Round((double)Price,2)})";
        public override bool CanExecuteCommand() =>
            !(Which is null || Weight is null || Count is null || Price is null);
           
    }
}
