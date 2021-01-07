using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double degreesCelsius = double.Parse(Console.ReadLine());

            // ( C * 1.8) +32 = F 
            double degreesFarenheit = (degreesCelsius * 1.8) + 32;

            Console.WriteLine($"{degreesFarenheit:f2}");
        }
    }
}
