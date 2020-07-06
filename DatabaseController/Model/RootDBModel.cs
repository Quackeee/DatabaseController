using DatabaseController.DAL;
using DatabaseController.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseController.Model
{
    class RootDBModel : DBModel
    {
        public ObservableCollection<Burning> Burnings { get; set; } = GetAllDBObjects<Burning>("select * from palenie");
        public ObservableCollection<Crop> Crops { get; set; } = GetAllDBObjects<Crop>("select * from zbior");
        public ObservableCollection<Farm> Farms { get; set; } = GetAllDBObjects<Farm>("select * from farma");
        public ObservableCollection<Package> Packages { get; set; } = GetAllDBObjects<Package>("select * from paczka");
        public ObservableCollection<Roasted> Roasteds { get; set; } = GetAllDBObjects<Roasted>("select * from wypalone");
        public ObservableCollection<RoastingRoom> RoastingRooms { get; set; } = GetAllDBObjects<RoastingRoom>("select * from palarnia");
        public ObservableCollection<Seed> Seeds { get; set; } = GetAllDBObjects<Seed>("select * from ziarna");

        public override void ReloadListings()
        {
            Burnings = GetAllDBObjects<Burning>("select * from palenie");
            Crops = GetAllDBObjects<Crop>("select * from zbior");
            Farms = GetAllDBObjects<Farm>("select * from farma");
            Packages = GetAllDBObjects<Package>("select * from paczka");
            Roasteds = GetAllDBObjects<Roasted>("select * from wypalone");
            RoastingRooms = GetAllDBObjects<RoastingRoom>("select * from palarnia");
            Seeds = GetAllDBObjects<Seed>("select * from ziarna");
        }
    }
}
