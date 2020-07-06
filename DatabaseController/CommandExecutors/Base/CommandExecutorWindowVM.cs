using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBase;

namespace DatabaseController.CommandExecutors.ViewModel
{
    class CommandExecutorWindowVM : ViewModelBase
    {
        private RelayCommand _execute;

        public CommandFormVM UtilizedCommandForm { get; }

        public RelayCommand Execute {
            get
            {
                Debug.WriteLine(UtilizedCommandForm is null);
                if (_execute is null)
                    _execute = new RelayCommand
                    (
                        arg => UtilizedCommandForm.ExecuteCommand(),
                        arg => UtilizedCommandForm.CanExecuteCommand()
                    );
                return _execute;
            }
        }

        public CommandExecutorWindowVM(CommandFormVM commandFormVM)
        {
            UtilizedCommandForm = commandFormVM;   
        }

        public CommandExecutorWindowVM() { }
    }
}
