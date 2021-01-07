using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfTrip = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBares = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalSumToys = (numberOfPuzzles * 2.60) + (numberOfDolls * 3) + (numberOfBares * 4.10) + 
                (numberOfMinions * 8.20) + (numberOfTrucks * 2);
            double totalNumToys = numberOfPuzzles + numberOfDolls + numberOfBares + numberOfPuzzles + numberOfTrucks;

            if (totalNumToys >= 50)
            {
                totalSumToys = totalSumToys - (totalSumToys * 0.25);
            }
            totalSumToys = totalSumToys - (totalSumToys * 0.10);

            if (totalSumToys >= priceOfTrip)
            {
                double moneyLeft = totalSumToys - priceOfTrip;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double neededMoney = priceOfTrip - totalSumToys;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }
        }
    }
}
