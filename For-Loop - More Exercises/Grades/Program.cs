using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studetsNumber = int.Parse(Console.ReadLine());
            double failStudent = 0;
            double sredenStudent = 0;
            double doburStudent = 0;
            double topStudent = 0;

            double mediumGrade = 0;

            for (int i = 0; i < studetsNumber; i++)
            {
                double examGrade = double.Parse(Console.ReadLine());

                if (examGrade>=2&&examGrade<=2.99)
                {
                    failStudent++;
                }
                else if (examGrade >= 3 && examGrade <= 3.99)
                {
                    sredenStudent++;
                }
                else if (examGrade >= 4 && examGrade <= 4.99)
                {
                    doburStudent++;
                }
                else
                {
                    topStudent++;
                }
                //examGrade >= 5;
                mediumGrade += examGrade;
            }
            double grade = mediumGrade / studetsNumber;
            double underTree = (failStudent / studetsNumber) * 100;
            double srdStu = (sredenStudent / studetsNumber) * 100;
            double dobStu = (doburStudent / studetsNumber) * 100;
            double topStu = (topStudent / studetsNumber) * 100;

            Console.WriteLine($"Top students: {topStu:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {dobStu:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {srdStu:f2}%");
            Console.WriteLine($"Fail: {underTree:f2}%");
            Console.WriteLine($"Average: {grade:f2}");
        }
    }
}
