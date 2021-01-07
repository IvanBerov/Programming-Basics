using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int collectedFromSales = int.Parse(Console.ReadLine());
            
            int sales = 0; // subirane na sredstva
            int salesCount = 0; //broq4 prodajbi

            int totalCash = 0;
            int cashCount = 0;

            int cardCount = 0;
            int totalCard = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int preices = int.Parse(command);

                salesCount++;

                if (salesCount % 2 != 0) //odd
                {
                    if (preices > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sales += preices;
                        cashCount++;
                        totalCash += preices;
                        Console.WriteLine("Product sold!");
                    }

                }
                else if(salesCount % 2 == 0) //even
                {
                    if(preices < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sales += preices;
                        cardCount++;
                        totalCard += preices;
                        Console.WriteLine("Product sold!");
                    }
                }

                if(collectedFromSales <= sales)
                {
                    double averageCashPayment = (totalCash * 1.0) / cashCount;
                    double averagePaymentCard = (totalCard * 1.0) / cardCount;

                    Console.WriteLine($"Average CS: {averageCashPayment:f2}");
                    Console.WriteLine($"Average CC: {averagePaymentCard:f2}");
                    break;
                }



                    command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
