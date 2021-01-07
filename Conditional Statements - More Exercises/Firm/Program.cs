using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workingOvertimeEmployees = int.Parse(Console.ReadLine());

            double workingHour = (days - (days * 0.10)) * 8;
            int overtimeHour = workingOvertimeEmployees * (2 * days);
            double totalHour = Math.Floor(workingHour + overtimeHour);

            if (totalHour >= neededHour)
            {
                double hoursLeft = totalHour - neededHour;
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else if (totalHour < neededHour)
            {
                double moreHours = neededHour - totalHour;
                Console.WriteLine($"Not enough time!{moreHours} hours needed.");
            }



        }
    }
}
