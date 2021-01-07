using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliasNum = int.Parse(Console.ReadLine()); 
            int hyacinthsNum = int.Parse(Console.ReadLine()); 
            int rosesNum = int.Parse(Console.ReadLine()); 
            int cactusNum = int.Parse(Console.ReadLine()); 
            double giftPrice = double.Parse(Console.ReadLine());

            double totalSum = (magnoliasNum * 3.25) + (hyacinthsNum * 4) + (rosesNum * 3.50) + (cactusNum * 8);
            double taxes = totalSum * 0.05;
            double sum = totalSum - taxes;

            if (sum >= giftPrice)
            {
                double moneyLeft = Math.Floor(sum - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else if (sum < giftPrice)
            {
                double neededMoney = Math.Ceiling(giftPrice - sum);
                Console.WriteLine($"She will have to borrow {neededMoney} leva.");
            }
        }
    }
}
