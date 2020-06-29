using DatabaseController.CommandExecutor.ViewModel;
using MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resx = DatabaseController.Properties.Resources;


namespace DatabaseController.ViewModel
{
    class MainWindowVM : MVVMBase.ViewModelBase
    {
        public DisplayCECommand ShowExampleCommandExecutor
        {
            get
            {
                return new DisplayCECommand(
                    arg => new ExampleCommandExecutorVM()
                    );
            }
        }
    }
}
