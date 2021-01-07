using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJudg = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            double totaSum = 0;
            int countGrades = 0;

            while (text != "Finish")
            {
                double sum = 0;

                for (int judge = 1; judge <= countJudg; judge++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    totaSum += grade;
                    countGrades++;
                }
                double average = sum / countJudg;
                Console.WriteLine($"{text} - {average:f2}.");

                text = Console.ReadLine();
            }
            double totalAverage = totaSum / countGrades;
            Console.WriteLine($"Student's final assessment is {totalAverage:f2}.");
        }
    }
}
