using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int amountOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            

            if (typeOfFlowers == "Roses")
            {
                if (amountOfFlowers <= 80)
                {
                    totalPrice = amountOfFlowers * 5;
                }

                else if (amountOfFlowers > 80)
                {
                    totalPrice = (amountOfFlowers * 5) * 0.90;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (amountOfFlowers <= 90)
                {
                    totalPrice = amountOfFlowers * 3.80;
                }
                else if (amountOfFlowers > 90)
                {
                    totalPrice = (amountOfFlowers * 3.80) * 0.85;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (amountOfFlowers <= 80)
                {
                    totalPrice = amountOfFlowers * 2.80;
                }
                else if (amountOfFlowers > 80)
                {
                    totalPrice = (amountOfFlowers * 2.80) * 0.85;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (amountOfFlowers >= 120)
                {
                    totalPrice = amountOfFlowers * 3;
                }
                else if (amountOfFlowers < 120)
                {
                    totalPrice = (amountOfFlowers * 3) * 1.15;
                }
            }
            else if(typeOfFlowers=="Gladiolus")
            {
                if (amountOfFlowers >= 80)
                {
                    totalPrice = amountOfFlowers * 2.50;
                }
                else if (amountOfFlowers < 80)
                {
                    totalPrice = (amountOfFlowers * 2.50) * 1.20;
                }
            }

            double moneyLeft = budget - totalPrice ;
            double neededMoney = totalPrice - budget;
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {amountOfFlowers} {typeOfFlowers} and {moneyLeft:f2} leva left.");
            }
            else if (budget < totalPrice)
            {
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }

          
        }
    }
}
