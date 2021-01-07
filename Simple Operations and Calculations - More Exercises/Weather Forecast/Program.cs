using System;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatIsTheWeather = Console.ReadLine();
            string weather = "sunny";
            if (whatIsTheWeather==weather)
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside! ");
            }
        }
    }
}
