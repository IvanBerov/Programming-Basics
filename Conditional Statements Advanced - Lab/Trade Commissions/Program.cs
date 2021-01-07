using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sels = double.Parse(Console.ReadLine());

            double commission = 0;

            if (town == "Sofia" && sels >= 0)
            {
                if (sels <= 500)
                {
                    commission = sels * 0.05;
                }
                else if (sels > 500 && sels <= 1000)
                {
                    commission = sels * 0.07;
                }
                else if (sels > 1000 && sels <= 10000)
                {
                    commission = sels * 0.08;
                }
                else
                {
                    commission = sels * 0.12;
                }
                Console.WriteLine($"{commission:f2}");
            }
            else if (town == "Varna" && sels >= 0)
            {
                if (sels <= 500)
                {
                    commission = sels * 0.045;
                }
                else if (sels > 500 && sels <= 1000)
                {
                    commission = sels * 0.075;
                }
                else if (sels > 1000 && sels <= 10000)
                {
                    commission = sels * 0.10;
                }
                else
                {
                    commission = sels * 0.13;
                }
                Console.WriteLine($"{commission:f2}");
            }
            else if (town == "Plovdiv" && sels >= 0)
            {
                if (sels <= 500)
                {
                    commission = sels * 0.055;
                }
                else if (sels > 500 && sels <= 1000)
                {
                    commission = sels * 0.08;
                }
                else if (sels > 1000 && sels <= 10000)
                {
                    commission = sels * 0.12;
                }
                else
                {
                    commission = sels * 0.145;
                }
                Console.WriteLine($"{commission:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
