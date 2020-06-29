using MVVMBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace DatabaseController.ViewModel
{
    internal class LogInVM : MVVMBase.ViewModelBase
    {
        private string currentLogin;
        private string currentPassword;
        private ICommand loginCommand = null;

        public LogInVM() { }

        public string CurrentLogin
        {
            get => currentLogin;
            set { currentLogin = value; OnPropertyChanged(nameof(CurrentLogin)); }
        }

        public string CurrentPassword
        {
            get => currentPassword;
            set { currentPassword = value; OnPropertyChanged(nameof(CurrentPassword)); }
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
                            loginToDatabase();
                        },
                        arg =>
                        {
                            if (currentLogin != null && currentPassword != null)
                                return true;
                            return false;
                        });
                }

                return loginCommand;
            }
        }

        private void loginToDatabase()
        {
            Debug.WriteLine("GOWNO JEBANE W DUPEEEEE");
        }
    }
}
