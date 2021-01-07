using System;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Лице = π * r * r
          //Периметър = 2 * π * r

            double r = double.Parse(Console.ReadLine());
            double perimetert = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimetert:f2}");
        }
    }
}
