using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double resultPoints = 0;
            double second = 0;
            double third = 0;
            double forth = 0;
            double fivth = 0;
            double sixsth = 0;
            double seventh = 0;
            
            


            for (int i = 0; i < count; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (numbers >= 0 && numbers <= 9)
                {
                    second++;
                    resultPoints += numbers * 0.2;
                }
                else if (numbers >= 10 &&numbers<= 19)
                {
                    third++;
                    resultPoints += numbers * 0.3;
                }
                else if (numbers >= 20 && numbers <= 29)
                {
                    forth++;
                    resultPoints += numbers * 0.4;
                }
                else if (numbers >= 30 && numbers <= 39)
                {
                    fivth++;
                    resultPoints += 50;
                }
                else if (numbers >= 40 && numbers <= 50)
                {
                    sixsth++;
                    resultPoints += 100;
                }
                else //invalid numbers
                {
                    seventh++;
                    resultPoints /= 2.0;
                }

            }


            double secondPrecent = (second / count) * 100;
            double thirdPrecent = (third / count) * 100;
            double forthPrecent = (forth / count) * 100;
            double fifthPrecent = (fivth / count) * 100;
            double sixthPrecent = (sixsth / count) * 100;
            double seventhPrecent = (seventh / count) * 100;


            Console.WriteLine($"{resultPoints:f2}");
            Console.WriteLine($"From 0 to 9: {secondPrecent:f2}%");
            Console.WriteLine($"From 10 to 19: {thirdPrecent:f2}%");
            Console.WriteLine($"From 20 to 29: {forthPrecent:f2}%");
            Console.WriteLine($"From 30 to 39: {fifthPrecent:f2}%");
            Console.WriteLine($"From 40 to 50: {sixthPrecent:f2}%");
            Console.WriteLine($"Invalid numbers: {seventhPrecent:f2}%");
        }
    }
}
