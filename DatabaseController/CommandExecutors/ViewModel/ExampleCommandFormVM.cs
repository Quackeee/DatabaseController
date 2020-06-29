using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.CommandExecutor.ViewModel
{
    class ExampleCommandExecutorVM : CommandFormVM
    {
        protected override string _generateCommandString()
        {
            throw new NotImplementedException();
        }
        public override bool CanExecuteCommand() => true;
    }
}
