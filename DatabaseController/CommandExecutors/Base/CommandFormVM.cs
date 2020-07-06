using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseController.DAL;
using MVVMBase;

namespace DatabaseController.CommandExecutors.ViewModel
{
    abstract class CommandFormVM : ViewModelBase, IExecuteCommand
    {
        protected abstract string _generateCommandString();
        public void ExecuteCommand()
        {
            DBConnection.ExecuteCommand(_generateCommandString());
        }
        public abstract bool CanExecuteCommand();
    }
}
