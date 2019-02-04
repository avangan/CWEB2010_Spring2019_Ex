using System;

namespace mplsRenters
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, regionOfCity;
            int floorCount;
            Apartment aApartment = new Apartment(); //Instantiation -Create new instance from the Apartment Class
            aApartment.Name = "Nord Haus";
            aApartment.Address = "315 First Ave NE";
            aApartment.FloorCount = 17;
            aApartment.RegionOfCity = "North";

            Apartment aApartment_Two = new Apartment();
            aApartment_Two.Name = "365 Nicollet";
            aApartment_Two.Address = "123 Nicollet Ave";
            aApartment_Two.FloorCount = 18;
            aApartment_Two.RegionOfCity = "South";

            Apartment[] apartments = new Apartment[2];
            var x = 0;
            while (x < apartments.Length)
            {

                Console.WriteLine("Please enter the name of the apartment");
                name = Console.ReadLine();

                Console.WriteLine("Please enter the address");
                address = Console.ReadLine();

                Console.WriteLine("Please enter the floor count of the apartment");
                floorCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the region of city for aparment");
                regionOfCity = Console.ReadLine();

                apartments[x] = new Apartment(name, address, floorCount, regionOfCity);
                x++;

            }

            Console.WriteLine(apartments[0].ToString());
            Console.WriteLine(apartments[1].ToString());


        }
    }
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
            this.RegionOfCity = RegionOfCity;
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

    abstract class User
    {
        protected string Fname { get; set; }
        protected string Lname { get; set; }
        protected string Phone { get; set; }
        protected string Email { get; set; }


        /**
         * Statements to format phone.  
         * Use the substring and decision making logic to reset any value that is passed during instantiation
        **/
        protected abstract void formatePhone();


        /**
         * Agents and profiles will have a classification that will have different criteria for how a classification
         * is assigned
         * */
        protected abstract void determineClassification();
        





    }


     class Agent : User
    {
        public string AgentStatus { get; set; }
        public string AgentCompanyName { get; set; }
        public string Classification { get; set; }



        protected override void determineClassification()
        {
            throw new NotImplementedException();
        }

        protected override void formatePhone()
        {
            throw new NotImplementedException();
        }
    }

    class Profile : User
    {
        public DateTime ExpectedMoveDate { get; set; }
        public string PreferredRegion { get; set; }
        public int BedCountSelection { get; set; }
        public int BathCountSelection { get; set; }
        public string Classification { get; }

        public double UpperRentValue { get; set; }
        public double LowerRentValue { get; set; }



        protected override void determineClassification()
        {
            throw new NotImplementedException();
        }

        protected override void formatePhone()
        {
            throw new NotImplementedException();
        }



    }
}

