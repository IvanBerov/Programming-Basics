using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtMeterW = double.Parse(Console.ReadLine());
            double widthMeterH = double.Parse(Console.ReadLine());

            //Залата е широка 890 cm.От тях 100 cm отиват за коридора в средата.
            //В останалите 790 cm могат да се разположат по 11 бюра на ред(11 * 70 cm = 770 cm + 20 cm остатък).
            //Залата е дълга 1500 cm.В тях могат да бъдат разположени 12 реда(12 * 120 cm = 1440 + 60 cm остатък).
            //Брой места = 12 * 11 - 3 = 132 - 3 = 129(имаме 12 реда по 11 места = 132 минус 3 места за катедра и входна врата).

            double widthCantimeters =( widthMeterH * 100) - 100;
            double deskInLíne = Math.Floor(widthCantimeters / 70);
            double lenghtCantimeters = lenghtMeterW * 100;
            double rows = Math.Floor(lenghtCantimeters / 120);

            double numberOfPlaces = (deskInLíne * rows) - 3;

            Console.WriteLine(numberOfPlaces);


        }
    }
}
