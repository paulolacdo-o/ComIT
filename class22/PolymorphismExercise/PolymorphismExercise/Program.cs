using PolymorphismExercise.BookTypes;
using System;

namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ListView = false;

            Book[] books = new Book[10];
            Initialize(books);

            Console.WriteLine("Use List View?(y/n)");
            string input = Console.ReadLine();

            if (input != "" && (input[0] == 'y' || input[0] == 'Y'))
                ListView = true;

            PrintBooks(books, ListView);

            Console.ReadKey();
        }

        static void PrintBooks(Book[] books, bool ListView)
        {
            Console.Clear();
            for (int i = 0; i < books.Length; i++)
            {
                books[i].PrintBookInformation();
                if(ListView)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.ReadKey();
                    if(i != books.Length-1)
                        Console.Clear();
                }
            }
        }

        static void Initialize(Book[] books)
        {
            books[0] = new PaperBack("Book1", "Author1", 100);
            books[1] = new PaperBack("Book2", "Author2", 125);
            books[2] = new PaperBack("Book3", "Author3", 150);
            books[3] = new PaperBack("Book4", "Author4", 175);
            books[4] = new PaperBack("Book5", "Author5", 200);
            books[5] = new HardCover("Book6", "Author6", 100);
            books[6] = new HardCover("Book7", "Author7", 125);
            books[7] = new HardCover("Book8", "Author8", 150);
            books[8] = new HardCover("Book9", "Author9", 175);
            books[9] = new HardCover("Book10", "Author10", 200);
        }
    }
}
