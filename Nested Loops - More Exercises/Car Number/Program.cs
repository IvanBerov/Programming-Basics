using System;

namespace Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= endNum; i++)
            {
                for (int v = firstNum; v <= endNum; v++)
                {
                    for (int a = firstNum; a <= endNum; a++)
                    {
                        for (int n = firstNum; n <= endNum; n++)
                        {
                            //Ако номерът започва с четна цифра, то той трябва да завършва на нечетна цифра и
                            //обратното – ако започва с нечетна,  завършва на четна
                            
                            if ((i % 2 == 0 && n % 2 != 0 && i > n && (v + a) % 2 == 0)||
                                (i % 2 != 0 && n % 2 == 0 && i > n && (v + a) % 2 == 0))
                            {
                                Console.Write("" + i + v + a + n + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
