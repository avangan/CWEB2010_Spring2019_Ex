using System;
using System.Collections.Generic;
using System.Text;

namespace mplsRenters
{
    class Apartment
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int FloorCount { get; set; }
        public string RegionOfCity { get; set; }
        private readonly double ESTIMATED_RENT_ONE = 1200.00;
        private readonly double ESTIMATED_RENT_TWO = 2000.00;
        private readonly double ESTIMATED_RENT_THREE = 4000.00;
        //Default Constructor
        public Apartment()
        {

        }

        //Overloaded Constructor
        public Apartment(string Name, string Address, int FloorCount, string RegionOfCity)
        {
            this.Name = Name;
            this.Address = Address;
            this.FloorCount = FloorCount;

            if (RegionOfCity == "West" || RegionOfCity == "East" || RegionOfCity == "South" || RegionOfCity == "North" || RegionOfCity == "None")
            {
                this.RegionOfCity = RegionOfCity;
            }
            else
            {
                throw new CityRegionException(nameof(RegionOfCity));
            }

        }
        public double estimatedRent()
        {
            return 3.00;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} \n, Address: {1} \n, FloorCount: {2} \n, Region of City: {3} \n", Name, Address, FloorCount, RegionOfCity);
        }
    }
}
