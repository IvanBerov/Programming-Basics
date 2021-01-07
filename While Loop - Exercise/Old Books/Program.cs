using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoritBook = Console.ReadLine();
            int checkedBooks = 0;

            while (true)
            {
                string bookName = Console.ReadLine();

                

                if (bookName == favoritBook) {
                    Console.WriteLine($"You checked {checkedBooks} books and found it.");
                    break;
                }
                else if (bookName=="No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    break;
                }
                else
                {
                    checkedBooks++;
                }
            }
        }
    }
}
