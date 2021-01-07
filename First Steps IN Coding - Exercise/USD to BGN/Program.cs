using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double UsdAmount = double.Parse(Console.ReadLine());
            double BgnAmount = UsdAmount * 1.79549;

            Console.WriteLine($"{BgnAmount:f2}");
        }
    }
}
