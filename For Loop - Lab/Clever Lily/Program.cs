using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double money = 10;
            double toys = 0;
            double saved = 0;

            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    saved += money;
                    saved -= 1;
                    money += 10;
                }
                else
                {
                    toys++;
                }
            }

            saved += toys * toysPrice;
            

            if (washingMachinePrice <= saved)
            {
                double moneyLeft = saved - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double neededMoney = washingMachinePrice - saved;
                Console.WriteLine($"No! {neededMoney:f2}");

            }

        }
    }
}
