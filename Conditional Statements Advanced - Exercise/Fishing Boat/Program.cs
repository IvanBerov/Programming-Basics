using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());

            
            double priceWithDiscount = 0;

            if (season == "Spring")
            {
                if (numberOfFishermen <= 6)
                {
                    priceWithDiscount = 3000 * 0.90;
                }
                else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
                {
                    priceWithDiscount = 3000 * 0.85;
                }else if (numberOfFishermen >= 12)
                {
                    priceWithDiscount = 3000 * 0.75;

                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                if (numberOfFishermen <= 6)
                {
                    priceWithDiscount = 4200 * 0.90;
                }
                else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
                {
                    priceWithDiscount = 4200 * 0.85;
                }
                else if (numberOfFishermen >= 12)
                {
                    priceWithDiscount = 4200 * 0.75;

                }
            }
            else if (season == "Winter")
            {
                if (numberOfFishermen <= 6)
                {
                    priceWithDiscount = 2600 * 0.90;
                }
                else if (numberOfFishermen > 6 && numberOfFishermen <= 11)
                {
                    priceWithDiscount = 2600 * 0.85;
                }
                else if (numberOfFishermen >= 12)
                {
                    priceWithDiscount = 2600 * 0.75;

                }
            }

            double totalPrice = 0;

            if (numberOfFishermen % 2 == 0)
            {
                if (season == "Autumn")
                {
                    totalPrice = priceWithDiscount;
                }
                else
                {
                    totalPrice = priceWithDiscount * 0.95;
                }
            }
            else
            {
                totalPrice = priceWithDiscount;
            }
            double moneyLeft = 0;
            double neededMoney = 0;

            if (budget >= totalPrice)
            {
                 moneyLeft = budget - totalPrice;

                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            
            {
                neededMoney = totalPrice - budget;

                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }

        }
    }
}
