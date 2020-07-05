using DatabaseController.CommandExecutor.ViewModel;
using DatabaseController.Model;
using MVVMBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Resx = DatabaseController.Properties.Resources;


namespace DatabaseController.ViewModel
{
    class MainWindowVM : MVVMBase.ViewModelBase
    {
        private LogInVM loginPanel;
        private SQLDatabase database;

        private ICommand loginCommand;

        public MainWindowVM()
        {
            loginPanel = new LogInVM();
        }
        
        public LogInVM LoginPanel
        {
            get => loginPanel;
            set { loginPanel = value; OnPropertyChanged(nameof(LoginPanel)); }
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

        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new RelayCommand(
                        arg =>
                        {
                            database = new SQLDatabase(LoginPanel.CurrentLogin, LoginPanel.CurrentPassword);                            
                        },
                        arg =>
                        {
                            if (LoginPanel.CurrentLogin == null || LoginPanel.CurrentPassword == null)
                                return false;      
                            return true;
                        });
                }
                return loginCommand;
            }
        }


    }
}
