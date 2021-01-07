using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double convertNumber = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();

            double result = 0;

            if (inputUnit == "m" && outputUnit == "cm")
            {
                result = convertNumber * 100;
            }else if (inputUnit == "m" && outputUnit == "mm")
            {
                result = convertNumber * 1000;
            }


            else if (inputUnit == "cm" && outputUnit == "m")
            {
                result = convertNumber / 100;
            }else if (inputUnit == "cm" && outputUnit == "mm")
            {
                result = convertNumber * 10;
            }


            else if (inputUnit == "mm" && outputUnit == "cm")
            {
                result = convertNumber / 10;
            }else if (inputUnit == "mm" && outputUnit == "m")
            {
                result = convertNumber / 1000;
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}
