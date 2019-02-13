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

            //string filePath = @"C:\Users\fulchr\Google Drive\Dunwoody\CWEB2010\Spring 2019\csharp_projects\mplsRenters\apartment_list.csv";

            string filePath = Directory.GetCurrentDirectory();
            string stepBackOne = Directory.GetParent(filePath).ToString();
            string stepBackTwo = Directory.GetParent(stepBackOne).ToString();
            string stepBackThree = Directory.GetParent(stepBackTwo).ToString();
            Console.WriteLine(stepBackThree);

            string adjustedFilePath = $@"{stepBackThree}\apartment_list.csv";
            Console.WriteLine(adjustedFilePath);




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

