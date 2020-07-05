using DatabaseController.CommandExecutor.ViewModel;
using DatabaseController.DAL;
using MVVMBase;
using DatabaseController.Model;
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
using System.Diagnostics;
using System.Windows.Navigation;

namespace DatabaseController.ViewModel
{
    class MainWindowVM : MVVMBase.ViewModelBase
    {
        private DBModel dbModel;
        public DBModel DbModel
        {
            get => dbModel;
            set { dbModel = value;OnPropertyChanged(nameof(DbModel)); }
        }

        private DataGridVM dataGridVM;
        public DataGridVM DataGridVM
        {
            get => dataGridVM;
            set { dataGridVM = value; OnPropertyChanged(nameof(DataGridVM)); }
        }

        private LogInVM loginPanel;
        public LogInVM LoginPanel
        {
            get => loginPanel;
            set { loginPanel = value; OnPropertyChanged(nameof(LoginPanel)); }
        }

        public MainWindowVM()
        {
            loginPanel = new LogInVM();
            dbModel = new DBModel();
            dataGridVM = new DataGridVM(dbModel);
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


        private ICommand loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (loginCommand == null)
                {
                    loginCommand = new RelayCommand(
                        arg =>
                        {
                            //DBConnection.LogIn(loginPanel.CurrentLogin, loginPanel.CurrentPassword);
                            //dbModel = new DBModel();
                            //dataGridVM = new DataGridVM(dbModel);
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

        private ICommand testCommand;
        public ICommand TestCommand
        {
            get
            {
                if(testCommand == null)
                {
                    testCommand = new RelayCommand(
                        arg =>
                        {
                            foreach (var x in dbModel.Farms)
                                Debug.WriteLine(x);
                        },
                        arg => { return true; });
                }
                return testCommand;
            }
        }

    }
}
