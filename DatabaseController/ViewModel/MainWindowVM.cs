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
        private LogInVM loginPanel;

        public MainWindowVM()
        {
            loginPanel = new LogInVM();
        }
        
        public DisplayCECommand ShowExampleCommandExecutor
        {
            get
            {
                return new DisplayCECommand(
                    arg => new ExampleCommandExecutorVM()
                    );
            }
        }

        public LogInVM LoginPanel
        {
            get => loginPanel;
            set { loginPanel = value; OnPropertyChanged(nameof(LoginPanel)); }
        }
    }
}
