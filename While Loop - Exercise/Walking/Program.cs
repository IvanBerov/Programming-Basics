using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int totalSteps = 0;
            bool success = false;

            while(command != "Going home")
            {
                int steps = int.Parse(command);
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    success = true;
                    break;
                }

                command = Console.ReadLine();
            }
            if (success)
            {
                int stepsOver = totalSteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int moreSteps = int.Parse(Console.ReadLine());
                totalSteps += moreSteps;

                if (totalSteps >= 10000)
                {
                    int stepsOver = totalSteps - 10000;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOver} steps over the goal!");
                }
                else
                {
                    int stepsReachGoal = 10000 - totalSteps;
                    Console.WriteLine($"{stepsReachGoal} more steps to reach goal.");
                }
            }
        }
    }
}
