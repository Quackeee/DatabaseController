using DatabaseController.DAL;
using DatabaseController.DAL.Entities;
using DatabaseController.DAL.Repositories;
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
        public ObservableCollection<Burning> Burnings { get; set; } = new ObservableCollection<Burning>();
        public ObservableCollection<Crop> Crops { get; set; } = new ObservableCollection<Crop>();
        public ObservableCollection<Farm> Farms { get; set; } = new ObservableCollection<Farm>();
        public ObservableCollection<Package> Packages { get; set; } = new ObservableCollection<Package>();
        public ObservableCollection<Roasted> Roasteds { get; set; } = new ObservableCollection<Roasted>();
        public ObservableCollection<RoastingRoom> RoastingRooms { get; set; } = new ObservableCollection<RoastingRoom>();
        public ObservableCollection<Seed> Seeds { get; set; } = new ObservableCollection<Seed>();

        public RootDBModel()
        {
            var burnings = BurningRep.GetAllBurnings();
            foreach (var x in burnings)
                Burnings.Add(x);

            var crops = CropRep.GetAllCrops();
            foreach (var x in crops)
                Crops.Add(x);

            var farms = FarmRep.GetAllFarms();
            foreach (var x in farms)
                Farms.Add(x);

            var packages = PackageRep.GetAllPackages();
            foreach (var x in packages)
                Packages.Add(x);

            var roasteds = RoastedRep.GetAllRoasted();
            foreach (var x in roasteds)
                Roasteds.Add(x);

            var roastingRooms = RoastingRoomRep.GetAllRoastingRooms();
            foreach (var x in roastingRooms)
                RoastingRooms.Add(x);

            var seeds = SeedRep.GetAllSeeds();
            foreach (var x in seeds)
                Seeds.Add(x);
        }
    }
}
