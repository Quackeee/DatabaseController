using DatabaseController.CommandExecutors.ViewModel;
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

        private LogInVM loginPanel;
        public LogInVM LoginPanel
        {
            get => loginPanel;
            set { loginPanel = value; OnPropertyChanged(nameof(LoginPanel)); }
        }

        private ListAndButtonsVM selectedLNBVM;
        public ListAndButtonsVM SelectedLNBVM
        {
            get => selectedLNBVM;
            set { selectedLNBVM = value; OnPropertyChanged(nameof(selectedLNBVM)); }
        }
        

        public MainWindowVM()
        {
            loginPanel = new LogInVM();
            //SelectedLNBVM = new RootVM();
            _mainWindow = this;
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
                            DBConnection.LogIn(loginPanel.CurrentLogin, loginPanel.CurrentPassword);
                            string role = DBConnection.GetUserRole();

                            if (role == "root")
                            {
                                SelectedLNBVM = new RootVM();
                                SelectedLNBVM.DbModel = new RootDBModel();
                            }
                            else if (role == "wlasciciel_palarni")
                            {
                                SelectedLNBVM = new RoasterVM();
                                SelectedLNBVM.DbModel = new RoasterDBModel();
                            }
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
