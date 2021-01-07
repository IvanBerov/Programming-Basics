using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            String typeGeometricFigure = Console.ReadLine();
            double area = 0;
            if(typeGeometricFigure== "square")
            {
                double lengthOfSide = double.Parse(Console.ReadLine());
                area = lengthOfSide * lengthOfSide;

            }
            else if(typeGeometricFigure== "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;

            }
            else if(typeGeometricFigure== "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                 area = Math.PI * radius * radius;

            }
            else if(typeGeometricFigure== "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                area = (side * hight) / 2;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
