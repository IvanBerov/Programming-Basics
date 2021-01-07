using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double engelRad = double.Parse(Console.ReadLine());
            double engelDeg = engelRad * 180 / Math.PI;

            Console.WriteLine(Math.Round(engelDeg));

        }
    }
    
}

