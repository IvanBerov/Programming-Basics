using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double handMoney = double.Parse(Console.ReadLine());

            int spendCount = 0;
            int daysCount = 0;
            
            while (true)
            {
                string spendSave = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());

                daysCount++;

                if (spendSave == "spend")
                {
                    spendCount++;
                    handMoney -= sum;

                    if (handMoney < 0)
                    {
                        handMoney = 0;
                    }                  
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }
                }
                    // save
                else
                {
                    spendCount = 0;
                    handMoney += sum;
                    if (handMoney>= neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {daysCount} days.");
                        break;
                    }
                }
            }
        }
    }
}
