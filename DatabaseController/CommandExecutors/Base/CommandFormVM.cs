using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DatabaseController.DAL;
using MVVMBase;

namespace DatabaseController.CommandExecutors.ViewModel
{
    abstract class CommandFormVM : ViewModelBase, IExecuteCommand
    {
        protected abstract string _generateCommandString();
        public void ExecuteCommand()
        {
            try
            {
                DBConnection.ExecuteCommand(_generateCommandString());
                _mainWindow.SelectedLNBVM.RefreshLisings();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public abstract bool CanExecuteCommand();
    }
}
