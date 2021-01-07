using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;
            string oddOrEven = string.Empty;
            string output = string.Empty;

            if (symbol == "+")
            {
               result = n1 + n2;

                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                output = $"{n1} {symbol} {n2} = {result} - {oddOrEven}";
            }
            else if (symbol == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                output = $"{n1} {symbol} {n2} = {result} - {oddOrEven}";

            }
            else if (symbol == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else
                {
                    oddOrEven = "odd";
                }
                output = $"{n1} {symbol} {n2} = {result} - {oddOrEven}";
            }
            else if (symbol == "/")
            {
                if (n2 == 0)
                {
                    output = $"Cannot divide {n1} by zero";
                }
                else
                {
                    result =(n1 * 1.0) / n2;

                    output = $"{n1} / {n2} = {result:f2}";
                }
            }
            else if (symbol == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;

                    output = $"{n1} % {n2} = {result}";
                }
            }
            Console.WriteLine(output);
        }
    }
}
