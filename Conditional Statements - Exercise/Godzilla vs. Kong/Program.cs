using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int actorNumber = int.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());

            double filmDecor = movieBudget * 0.10;
            double totalClothingPrice = actorNumber * priceForClothing;

            if (actorNumber > 150)
            {
                totalClothingPrice = actorNumber * (priceForClothing - (priceForClothing * 0.10)) ;
            }

            double totalExpenses = totalClothingPrice + filmDecor;

            if (totalExpenses > movieBudget)
            {
                double neededMoney = totalExpenses - movieBudget;

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }

            else if (totalExpenses <= movieBudget)
            {
                double moneyLeft = movieBudget - totalExpenses;

                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
}
