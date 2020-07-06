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
        public RootVM() => DbModel = new RootDBModel();

        public string CommandString { get; set; }

        public RelayCommand Execute
        {
            get => new RelayCommand
                (
                    arg =>
                    {
                        DBConnection.ExecuteCommand(CommandString);
                    }
                );
        }
    }
}
