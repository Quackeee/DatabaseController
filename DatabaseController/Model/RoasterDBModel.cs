using DatabaseController.DAL;
using DatabaseController.DAL.Entities.Roaster;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    class RoasterDBModel : DBModel
    {
        public ObservableCollection<MySeed> MySeeds { get; set; } = GetAllDBObjects<MySeed>("SELECT * FROM moje_ziarna");
        public ObservableCollection<MyRoastingRoom> MyRoastingRooms { get; set; } = GetAllDBObjects<MyRoastingRoom>("SELECT * FROM moja_palarnia");
        public ObservableCollection<MyPackage> MyPackages { get; set; } = GetAllDBObjects<MyPackage>("SELECT * FROM moje_paczki");

        public override void ReloadListings()
        {
            MySeeds = GetAllDBObjects<MySeed>("SELECT * FROM moje_ziarna");
            MyRoastingRooms = GetAllDBObjects<MyRoastingRoom>("SELECT * FROM moja_palarnia");
            MyPackages = GetAllDBObjects<MyPackage>("SELECT * FROM moje_paczki");
        }
    }
}
