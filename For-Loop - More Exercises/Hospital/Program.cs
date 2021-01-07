using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int periodOfTime = int.Parse(Console.ReadLine());

            int inspected = 0;
            int uninspected = 0;
            int doctors = 7;


            for (int i = 1; i <= periodOfTime; i++)
            {
                if (i % 3 == 0 && uninspected > inspected)
                {
                    doctors++;
                }

                int numberOfPatients = int.Parse(Console.ReadLine());

                if (numberOfPatients <= 7)
                {
                   inspected += numberOfPatients;
                }
                // numberOfPatients > 7
                else
                {
                    inspected += doctors;
                    uninspected += numberOfPatients - doctors;
                }
                
            }
           Console.WriteLine($"Treated patients: {inspected}.");

           Console.WriteLine($"Untreated patients: {uninspected}.");
        }
    }
}
