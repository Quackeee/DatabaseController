using DatabaseController.CommandExecutors.ViewModel;
using DatabaseController.DAL;
using DatabaseController.Model;
using MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.ViewModel
{
    class RootVM : ListAndButtonsVM
    {

        private string _outputMessage;

        public string CommandString { get; set; }
        public string OutputMessage { get => _outputMessage; set { _outputMessage = value; OnPropertyChanged(nameof(OutputMessage)); } }

        public RootVM() => DbModel = new RootDBModel();

        public RelayCommand Execute
        {
            get => new RelayCommand
                (
                    arg =>
                    {
                        OutputMessage = DBConnection.TryExecuteCommand(CommandString);
                        RefreshLisings();
                    }
                );
        }
    }
}
