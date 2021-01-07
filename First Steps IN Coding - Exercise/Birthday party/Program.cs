using System;

namespace Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double tortePrice = hallRent * 0.20 ;
            double drinksPrise = tortePrice - (tortePrice * 0.45) ;
            double animatorPrice = hallRent / 3 ;

            double totalBudget = hallRent + tortePrice + drinksPrise + animatorPrice;

            Console.WriteLine(totalBudget);

        }
    }
}
