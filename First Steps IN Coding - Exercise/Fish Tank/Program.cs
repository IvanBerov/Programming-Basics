using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.Дължина в см – цяло число в интервала[10 … 500]
            int lengthInCm = int.Parse(Console.ReadLine());
            //7.Широчина в см – цяло число в интервала[10 … 300]
            int widthInCm = int.Parse(Console.ReadLine());
            //8.Височина в см – цяло число в интервала[10… 200]
            int hightInCm = int.Parse(Console.ReadLine());
            //9.Процент – реално число в интервала[0.000 … 100.000]
            double percentageOfCapacity = double.Parse(Console.ReadLine());

            int volumeOfAquarium = lengthInCm * widthInCm * hightInCm;
            double totalLitersCollect = volumeOfAquarium * 0.001;
            double percent = percentageOfCapacity * 0.01;

            double finalLiters = totalLitersCollect - (totalLitersCollect * percent);

            Console.WriteLine(finalLiters);
            

        }
    }
}
