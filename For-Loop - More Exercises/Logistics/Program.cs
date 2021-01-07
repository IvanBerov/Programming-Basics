using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());

            double microbusTon = 0;
            double tirTon = 0;
            double trainTon = 0;

            for (int i = 0; i < numberOfLoads; i++)
            {
                int cargoTonnage = int.Parse(Console.ReadLine());

                if (cargoTonnage <= 3)
                {
                    microbusTon += cargoTonnage;
                }
                else if (cargoTonnage >= 4 && cargoTonnage <= 11)
                {
                    tirTon += cargoTonnage;
                }
                // 12 и повече тона
                else
                {
                    trainTon += cargoTonnage;
                }
            }

            double totalTon = microbusTon + tirTon + trainTon;
            double pricePerTon = ((microbusTon * 200) + (tirTon * 175) + (trainTon * 120)) / totalTon;
            // процента на тоновете  превозвани с всяко превозно средство,спрямо общото тегло(в тонове) на всички товари

            double precentMicrobus = (microbusTon / totalTon) * 100; 
            double precentTir = (tirTon / totalTon) * 100; 
            double precentTrain = (trainTon / totalTon) * 100; 



            //Първи ред – средната цена на тон превозен товар(закръглена до втория знак след дес. запетая);
            Console.WriteLine($"{pricePerTon:f2}");

            // Втори ред – процентът тона превозвани с микробус(процент между 0.00 % и 100.00 %)
            //Трети ред – процентът тона превозвани с камион(процент между 0.00 % и 100.00 %)
            //Четвърти ред – процентът тона превозвани с влак(процент между 0.00 % и 100.00 %)

            Console.WriteLine($"{precentMicrobus:f2}%");
            Console.WriteLine($"{precentTir:f2}%");
            Console.WriteLine($"{precentTrain:f2}%");
        }
    }
}
