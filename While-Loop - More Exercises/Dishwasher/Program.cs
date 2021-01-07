using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles = int.Parse(Console.ReadLine());

            int dishWashed = 0;
            int countDish = 0;

            int totalWash = numberOfBottles * 750;

            int countPots = 0;
            int countDishes = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int dishNum = int.Parse(command);
                countDish++;
                if (countDish % 3 == 0)
                {
                    countPots += dishNum;
                    dishWashed = dishNum * 15;
                    totalWash -= dishWashed;
                }
                else 
                { 

                    countDishes += dishNum;
                    dishWashed = dishNum * 5;
                    totalWash -= dishWashed;
                }
                if (totalWash < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalWash)} ml. more necessary!");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                if (totalWash >= 0)
                {
                    Console.WriteLine("Detergent was enough!");

                    Console.WriteLine($"{countDishes} dishes and {countPots} pots were washed.");

                    Console.WriteLine($"Leftover detergent {totalWash} ml.");
                }
                else
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalWash)} ml. more necessary!");
                }
                
            }
               
        }
    }
}

