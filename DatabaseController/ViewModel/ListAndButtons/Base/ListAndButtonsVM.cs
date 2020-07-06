using DatabaseController.DAL;
using MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.ViewModel
{
    abstract class ListAndButtonsVM : ViewModelBase
    {
        private DBModel dbModel;
        public DBModel DbModel
        {
            get => dbModel;
            set { dbModel = value; OnPropertyChanged(nameof(DbModel)); }
        }
    }
}
