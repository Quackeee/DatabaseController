using DatabaseController.DAL;
using DatabaseController.Model;
using MVVMBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.ViewModel
{
    class DataGridVM : ViewModelBase
    {
        private DBModel dbModel = null;
        
        private ObservableCollection<Farm> farms = null;
        public ObservableCollection<Farm> Farms
        {
            get { return farms; }
            set
            {
                farms = value;
                OnPropertyChanged(nameof(Farms));
            }
        }

        public Farm CurrentFarm { get; set; }

        public DataGridVM(DBModel dbModel)
        {
            this.dbModel = dbModel;
            farms = dbModel.Farms;
        }


    }
}
