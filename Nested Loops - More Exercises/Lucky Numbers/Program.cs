using System;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <=9; i++)
            {
                for (int v = 1; v <= 9; v++)
                {
                    for (int a = 1; a <=9; a++)
                    {
                        for (int n = 1; n <= 9; n++)
                        {
                            if ((i + v) == (a + n))
                            {
                                if (N % (i + v) == 0)
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
}
//Щастливо число е 4-цифрено число, на което сбора от първите две цифри е равен на сбора от последните две. 
//Числото N трябва да се дели без остатък от сбора на първите две цифри на "щастливото" число. 