using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double totalP1 = p1 * h;
            double totalP2 = p2 * h;
            double totalLiters = totalP1 + totalP2;
            

            //До колко се е запълнил басейна и коя тръба с колко процента е допринесла. 
            // "The pool is {запълненост на басейна в проценти}% full. Pipe 1: {процент вода от първата тръба}%. Pipe 2: {процент вода от втората тръба}%."
            if (totalLiters <= v)
            {
                double poolOccupancyPercent = (totalLiters / v) * 100;
                double percentageFirstPipe = (totalP1 / totalLiters) * 100;
                double precentageSecondPipe = (totalP2 / totalLiters) * 100;

                Console.WriteLine($"The pool is {poolOccupancyPercent:f2}% full. Pipe 1: {percentageFirstPipe:f2}%. Pipe 2: {precentageSecondPipe:f2}%.");

            }
            //Aко басейнът се е препълнил – с колко литра е прелял за даденото време. 
            //"For {часовете, които тръбите са пълнили вода} hours the pool overflows with {литрите вода в повече} liters."
            else
            {
                double litersMore = totalLiters - v;
                Console.WriteLine($"For {h:f2} hours the pool overflows with {litersMore:f2} liters.");
            }
        }
    }
}
