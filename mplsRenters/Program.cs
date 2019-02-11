using System;

namespace mplsRenters
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, phone, email, agentStatus, agentCompany;
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

            Agent[] agents = new Agent[2];
            var x = 0;
            while (x < agents.Length)
            {

                Console.WriteLine("Please enter first name");
                firstName = Console.ReadLine();

                Console.WriteLine("Please enter last name");
                lastName = Console.ReadLine();

                Console.WriteLine("Please enter phone");
                phone = Console.ReadLine();

                Console.WriteLine("Please enter email");
                email = Console.ReadLine();

                Console.WriteLine("Please enter agent status");
                agentStatus = Console.ReadLine();

                Console.WriteLine("Please enter agent company name");
                agentCompany = Console.ReadLine();

                agents[x] = new Agent(firstName, lastName, phone, email, agentStatus,agentCompany);
                x++;

            }

            Console.WriteLine(agents[0].AgentStatus);
            Console.WriteLine(agents[1].AgentStatus);


   

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

        public User(string Fname, string Lname, string phone, string Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            Phone = phone;
            this.Email = Email;
        }

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

        public Agent(string Fname, string Lname, string phone, string Email, string AgentStatus, string AgentCompanyName) : base(Fname, Lname, phone, Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            Phone = phone;
            this.Email = Email;
            this.AgentStatus = AgentStatus;
            this.AgentCompanyName = AgentCompanyName;

        }

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

        public Profile(string Fname, string Lname, string phone, string Email) : base(Fname, Lname, phone, Email)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            Phone = phone;
            this.Email = Email;
           

        }

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

