using System;

namespace mplsRenters
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, lastName, phone, email, regionOfCity;
            int floorCount;
            //Apartment aApartment = new Apartment(); //Instantiation -Create new instance from the Apartment Class
            //aApartment.Name = "Nord Haus";
            //aApartment.Address = "315 First Ave NE";
            //aApartment.FloorCount = 17;
            //aApartment.RegionOfCity = "North";

            //Apartment aApartment_Two = new Apartment();
            //aApartment_Two.Name = "365 Nicollet";
            //aApartment_Two.Address = "123 Nicollet Ave";
            //aApartment_Two.FloorCount = 18;
            //aApartment_Two.RegionOfCity = "South";

            Apartment[] apartments = new Apartment[2];
            var x = 0;
            while (x < apartments.Length)
            {

                Console.WriteLine("Please enter apartment name");
                name = Console.ReadLine();

 

                Console.WriteLine("Please enter address");
                address = Console.ReadLine();

                Console.WriteLine("Please enter floor count");
                floorCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter Region of city");
                regionOfCity = Console.ReadLine();


                try
                {
                    apartments[x] = new Apartment(name, address, floorCount, regionOfCity);
                }catch(Exception e)
                {
                    Console.WriteLine( e.Message );
                    apartments[x] = new Apartment(name, address, floorCount, "None");
                }
                x++;

            }

            Console.WriteLine(apartments[0].ToString());
            Console.WriteLine(apartments[1].ToString());


   

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

    public class CityRegionException : Exception
    {
        public CityRegionException(string aMessage) : base(aMessage)
        {
            Console.WriteLine(aMessage + " was not one of the 4 Regions");
        }
    }
}

