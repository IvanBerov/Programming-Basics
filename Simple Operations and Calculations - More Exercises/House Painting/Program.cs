using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double greenPaintOneLiter = 3.4;
            double redPaintOneLiter = 4.3;

            double frontAndRearWall = ((x * x) - (1.2 * 2)) + (x * x);
            double theSideWalls = 2 * ((x * y) - (1.5 * 1.5));
            double TotalGreenPaint = (frontAndRearWall + theSideWalls) / greenPaintOneLiter;

            double areaRoof = 2*((x * h) / 2) + 2*(x * y);
            double totalRedPaint = areaRoof / redPaintOneLiter;

            Console.WriteLine($"{TotalGreenPaint:f2}");
            Console.WriteLine($"{totalRedPaint:f2}");


        }
    }
}
