using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordToImproveSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double ivansTime = distanceInMeters * timeInSec;
            double slowingTime =Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = ivansTime + slowingTime;
            double neededSec = totalTime - recordToImproveSec;

            if (recordToImproveSec > totalTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

            else if (totalTime >= recordToImproveSec)

            {
               Console.WriteLine($" No, he failed! He was {neededSec:f2} seconds slower.");
            }
        }
    }
}
