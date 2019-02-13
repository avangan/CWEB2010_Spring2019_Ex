using System;
using System.Collections.Generic;
using System.IO;

namespace mplsRenters
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, address, regionOfCity;
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
 
    public class CityRegionException : Exception
    {
        public CityRegionException(string aMessage) : base(aMessage)
        {
            Console.WriteLine(aMessage + " was not one of the 4 Regions");
        }
    }
}

