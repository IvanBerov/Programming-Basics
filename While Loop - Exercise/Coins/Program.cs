using System;
using System.Collections.Specialized;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto = double.Parse(Console.ReadLine());

            double restoCoins = Math.Floor(resto * 100);

            int countCoins = 0;

            while (restoCoins != 0)
            {
                if (restoCoins >= 200)
                {
                    restoCoins -= 200;                  
                }
                else if (restoCoins >= 100)
                {
                    restoCoins -= 100;
                }
                else if (restoCoins >= 50)
                {
                    restoCoins -= 50;
                }
                else if (restoCoins >= 20)
                {
                    restoCoins -= 20;
                }
                else if (restoCoins >= 10)
                {
                    restoCoins -= 10;
                }
                else if (restoCoins >= 5)
                {
                    restoCoins -= 5;                   
                }
                else if (restoCoins >= 2)
                {
                    restoCoins -= 2;
                }
                else if (restoCoins >= 1)
                {
                    restoCoins -= 1;
                }
                countCoins++;
            }
            Console.WriteLine(countCoins);
        }
    }
}
