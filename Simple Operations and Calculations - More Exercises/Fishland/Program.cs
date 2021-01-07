using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceMackerelPerKg = double.Parse(Console.ReadLine());
            double priceSpratPerKg = double.Parse(Console.ReadLine());

            double kgBonito = double.Parse(Console.ReadLine());
            double kgHorseMackerel = double.Parse(Console.ReadLine());
            int    kgMussels = int.Parse(Console.ReadLine());

            double priceBonitoPerKg = priceMackerelPerKg + (priceMackerelPerKg * 0.60);
            double priceHorseMackerelPerKg = priceSpratPerKg + (priceSpratPerKg * 0.80);
            double priceMusselsPerKg = 7.50;

            double totalPriceBonito = priceBonitoPerKg * kgBonito;
            double totalPriceHorseMackerel = priceHorseMackerelPerKg * kgHorseMackerel;
            double totalPriceMussels = priceMusselsPerKg * kgMussels;

            double totalAmountToPay = totalPriceBonito + totalPriceHorseMackerel + totalPriceMussels;

            Console.WriteLine($"{totalAmountToPay:f2}");



        }
    }
}
