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
    class RoasterVM : ListAndButtonsVM
    {
        public DisplayCECommand ShowSellCommandExecutor
        {
            get
            {
                return new DisplayCECommand(
                    arg => new SellCommandExecutorVM()
                    );
            }
        }
        public DisplayCECommand ShowRoastCommandExecutor
        {
            get
            {
                return new DisplayCECommand(
                    arg => new RoastCommandExecutorVM()
                    );
            }
        }
        public DisplayCECommand ShowPackCommandExecutor
        {
            get
            {
                return new DisplayCECommand(
                    arg => new PackCommandExecutorVM()
                    );
            }
        }
        public RoasterVM() => DbModel = new RoasterDBModel();
    }
}
