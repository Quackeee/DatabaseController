using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.CommandExecutor.ViewModel
{
    interface IExecuteCommand
    {
        void ExecuteCommand();
        bool CanExecuteCommand();
    }
}
