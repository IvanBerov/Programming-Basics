using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {

            int wineyardAreaX = int.Parse(Console.ReadLine());
            double grapesKgY = double.Parse(Console.ReadLine());
            int wineLitersZ = int.Parse(Console.ReadLine());
            int nuberOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = wineyardAreaX * grapesKgY ;
            double totalWine = (totalGrapes * 0.40) / 2.5;

             if (totalWine < wineLitersZ)
             {
                double neededWine = wineLitersZ - totalWine;


                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine)} liters wine needed.");
             }

            else if (totalWine >= wineLitersZ)
            {
                double litersLeft = totalWine - wineLitersZ;
                double litersEachWorker = litersLeft / nuberOfWorkers;

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Round(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersLeft)} liters left -> {Math.Ceiling(litersEachWorker)} liters per person. ");
            }
            
             //90 ot 100
           
             

        }
    }
}
