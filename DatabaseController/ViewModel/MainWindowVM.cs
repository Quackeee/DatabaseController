using DatabaseController.CommandExecutor.ViewModel;
using DatabaseController.Model;
using MVVMBase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
        private DataGrid dataGrid;
        private SQLDatabase database;

        private ICommand loginCommand;

        public MainWindowVM()
        {
            loginPanel = new LogInVM();
            dataGrid = new DataGrid();
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

                            DataGridTextColumn col1 = new DataGridTextColumn();
                            DataGridTextColumn col2 = new DataGridTextColumn();
                            DataGridTextColumn col3 = new DataGridTextColumn();
                            DataGridTextColumn col4 = new DataGridTextColumn();

                            dataGrid.Columns.Add(col1);
                            dataGrid.Columns.Add(col2);
                            dataGrid.Columns.Add(col3);
                            dataGrid.Columns.Add(col4);

                            col1.Binding = new Binding("kurwa");
                            col2.Binding = new Binding("jebana");
                            col3.Binding = new Binding("mac");
                            col4.Binding = new Binding("ASDADA");
                            col1.Header = "SDAD";
                            col2.Header = "SD";
                            col3.Header = "SDADsdasdad";
                            col4.Header = "sdadaaaaa";

                            dataGrid.Items.Add(new Farm("a", "b", "c", "d"));
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
