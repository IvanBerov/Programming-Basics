using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            int depositInMonths = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double totalInterest = depositAmount * (annualInterestRate/100);
            double monthInterest = totalInterest / 12;
            double endAmount = depositAmount + (depositInMonths * monthInterest);

            Console.WriteLine(endAmount);

        }
    }
}
