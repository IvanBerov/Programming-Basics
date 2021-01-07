using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litersFuel = double.Parse(Console.ReadLine());
            string fuel = "";

            if (litersFuel >= 25)
            {
                if(fuelType == "Diesel")
                {
                    fuel = "diesel";

                    Console.WriteLine($"You have enough {fuel}.");

                }else if (fuelType == "Gasoline")
                {
                    fuel = "gasoline";

                    Console.WriteLine($"You have enough {fuel}.");

                }else if (fuelType == "Gas")
                {
                    fuel = "gas";
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
                
            }


            else if (litersFuel < 25)
            {
                if (fuelType == "Diesel")
                {
                    fuel = "diesel";
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else if (fuelType == "Gasoline")
                {
                    fuel = "gasoline";
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else if (fuelType == "Gas")
                {
                    fuel = "gas";
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else
                {
                    Console.WriteLine("Invalid fuel!");
                }
            }
            
        }
    }
}
