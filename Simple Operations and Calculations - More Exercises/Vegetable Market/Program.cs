using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetablesKg = double.Parse(Console.ReadLine());
            double priceFruitsKg = double.Parse(Console.ReadLine());
            int totalKgVegetables = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());

            double incomeInLeva = (priceFruitsKg * totalKgFruits) + (priceVegetablesKg * totalKgVegetables);
            double incomeInEuro = incomeInLeva / 1.94;

            Console.WriteLine($"{incomeInEuro:f2}");

        }
    }
}
