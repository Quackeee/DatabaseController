using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.CommandExecutors.ViewModel
{
    class SellCommandExecutorVM : CommandFormVM
    {
        public int? Which { get; set; }
        public int? HowMany { get; set; }

        protected override string _generateCommandString() => $"call sprzedaj({Which},{HowMany})";
        public override bool CanExecuteCommand() => !(Which is null || HowMany is null);
    }
}
