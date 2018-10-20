using System;

namespace ThreeBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] book = new Book[3];
            
            int bookWithMostPages = 0;
            int prevMostPages = 0;
            string title;
            int pages;

            for(int i = 0; i < book.Length; i++)
            {
                Console.Write("Enter book title: ");
                title = Console.ReadLine();
                Console.Write("Enter number of pages: ");
                pages = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                book[i] = new Book(title, pages);

                if(pages > prevMostPages)
                {
                    prevMostPages = pages;
                    bookWithMostPages = i;
                }
            }

            Console.WriteLine("\n" +
                $"The book with most pages is {book[bookWithMostPages].title}.\n" +
                $"It has {book[bookWithMostPages].pages} pages.\n");

            Console.WriteLine("Press [Enter] key to exit program.");
            Console.ReadLine();
        }
    }
}
