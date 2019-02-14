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
            string[] arrayOfValues;
            List<Apartment> listOfApartments = new List<Apartment>();

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

            if (File.Exists(adjustedFilePath))
            {

                FileStream file = new FileStream(adjustedFilePath, FileMode.Open, FileAccess.Read);
                StreamReader read = new StreamReader(file);
                string t = read.ReadLine();
                Console.WriteLine(t + " This is the first Line");

                //while (!read.EndOfStream)
                //{
                //    try
                //    {
                //        //Serialize the objects into our program
                //        //string t = read.ReadLine();
                //        //Console.WriteLine(t);
                //        //listOfApartments.Add(new Apartment(arrayOfValues[0], arrayOfValues[1], Int32.Parse(arrayOfValues[2]), arrayOfValues[3]));
                //    }catch(Exception e)
                //    {
                //        Console.WriteLine(e.Message);
                       
                //    }

                //}
                read.Close();
                file.Close();

                listOfApartments.ForEach(i => Console.WriteLine(i.ToString()));


                //Demonstrate Writing to a file
                FileStream aFile = new FileStream(adjustedFilePath, FileMode.Append, FileAccess.Write);
                StreamWriter writeInfo = new StreamWriter(aFile);


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
                        writeInfo.WriteLine($"{name},{address},{floorCount},{regionOfCity}");


                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        
                        writeInfo.WriteLine($"{name},{address},{floorCount},None");

                    }
                    x++;

                }//End of While

                writeInfo.Close();
                aFile.Close();
            }
            else
            {
                Console.WriteLine("The file does not exist, please identify the file and restart program");
            }


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

