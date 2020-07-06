using DatabaseController.CommandExecutors.ViewModel;
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
    }
}
