using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double quantityOfBananas = double.Parse(Console.ReadLine());
            double quantityOfOranges = double.Parse(Console.ReadLine());
            double quantityOfRaspberries = double.Parse(Console.ReadLine());
            double quantityOfSrawberries = double.Parse(Console.ReadLine());

            double priceOfRaspberries = priceOfStrawberries * 0.5;
            double priceOfOranges = priceOfRaspberries - (priceOfRaspberries * 0.4);
            double priceOfBananas = priceOfRaspberries - (priceOfRaspberries * 0.8);

            double raspberriesAmount = priceOfRaspberries * quantityOfRaspberries;
            double orangesAmount = priceOfOranges * quantityOfOranges;
            double bananasAmount = priceOfBananas * quantityOfBananas;
            double strawberriesAmount = priceOfStrawberries * quantityOfSrawberries;

            double totalAmount = raspberriesAmount + orangesAmount + bananasAmount + strawberriesAmount;

            Console.WriteLine($"{totalAmount:f2}");

        }
    }
}
