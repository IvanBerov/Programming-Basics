using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int unsatisfactoryGrade = int.Parse(Console.ReadLine());
            string taskName = Console.ReadLine();

            double averageGrade = 0;
            int poorGrade = 0;
            int totalGrade = 0;
            string lastProblem = "";



            while (taskName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                totalGrade++;
                averageGrade += grade;

                if (grade <= 4)
                {
                    poorGrade++;
                }

                if (poorGrade == unsatisfactoryGrade)
                {
                    Console.WriteLine($"You need a break, {poorGrade} poor grades.");
                    break;
                }

                lastProblem = taskName;
                taskName = Console.ReadLine();

            }

            if (poorGrade != unsatisfactoryGrade) 
            { 
                averageGrade /= (totalGrade * 1.0);
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {totalGrade}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
