using System;

namespace SimpLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_TITLES = 32; //change this if you want more of each book title in the library

            bool isQuit = false;
            int numOfTitles = 0;
            Book[] books = new Book[MAX_TITLES];

            Console.WriteLine("Welcome to SimpLibrary!");
            Console.WriteLine($"We are currently able to hold {MAX_TITLES} book titles.");

            while(!isQuit)
            {
                PrintOptions();
                switch (ReadChoice())
                {
                    case 1: isQuit = true;
                        break;
                    case 2:
                        if (numOfTitles < MAX_TITLES)
                        {
                            books[numOfTitles++] = CreateBook();
                            Console.Write("\nBook added to library!" +
                                "\nPress any key to proceed.");
                        }
                        else
                        {
                            Console.Write("\nSorry, there are no more space available for new titles!" +
                                "\nPress any key to proceed.");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        TakeOutBook(books, numOfTitles);
                        break;
                    case 4:
                        ReturnBook(books, numOfTitles);
                        break;
                    case 5:
                        ListBooks(books, numOfTitles);
                        break;
                    default:
                        break;

                }
            }
            Console.Write("\nThank you for using the SimpLibrary." +
                "\nPress any key to exit.");
            Console.ReadKey();

        }

        static void ListBooks(Book[] books, int numOfTitles)
        {
            Console.WriteLine("\nHere are all the titles in the library:");
            if (numOfTitles == 0)
            {
                Console.WriteLine("There are no books in the library." +
                    "\nHow depressing!");
            }
            else
            {
                for (int i = 0; i < numOfTitles; i++)
                {
                    Console.WriteLine($"Index {i} - " +
                        books[i].ToString());
                }
            }
            Console.Write("\nPress any key to proceed.");
            Console.ReadKey();
        }

        static void ReturnBook(Book[] books, int numOfTitles)
        {
            int bookIndex;

            Console.Write("\nWhich book do you want to return?" +
                "\nPlease enter its index number: ");
            while (!(Int32.TryParse(Console.ReadLine(), out bookIndex)) || (bookIndex < 0 || bookIndex >= numOfTitles))
            {
                Console.Write("\nError: Index value does not exist!" +
                    "\nPlease try again: ");
            }
            if(books[bookIndex].Return())
            {
                Console.WriteLine($"\nYou have returned { books[bookIndex].Title} by { books[bookIndex].Title}." +
                    $"\nThank you for returning it on time.");
            }
            else
            {
                Console.WriteLine($"\nYou have not borrowed { books[bookIndex].Title} by { books[bookIndex].Author}." +
                    $"\nPlease check your information and try again.");
            }
            Console.Write("\nPress any key to proceed.");
            Console.ReadKey();
        }

        static void TakeOutBook(Book[] books, int numOfTitles)
        {
            int bookIndex;

            Console.Write("\nWhich book do you want to take out?" +
                "\nPlease enter its index number: ");
            while (!(Int32.TryParse(Console.ReadLine(), out bookIndex)) || (bookIndex < 0 || bookIndex >= numOfTitles))
            {
                Console.Write("\nError: Index value does not exist!" +
                    "\nPlease try again: ");
            }
            if (books[bookIndex].Loan())
            {
                Console.WriteLine($"\nYou have borrowed {books[bookIndex].Title} by {books[bookIndex].Author}." +
                    $"\nPlease return the book on or before the end of the lending period.");
            }
            else
            {
                Console.WriteLine($"\nSorry, there are no more available copies of {books[bookIndex].Title} by {books[bookIndex].Author} to lend out.");
            }

            Console.Write("\nPress any key to proceed.");
            Console.ReadKey();
        }

        static Book CreateBook()
        {
            string title, author;
            int copies;

            Console.Write("\nEnter the title of the book: ");
            while((title = Console.ReadLine()) == "")
            {
                Console.Write("Error: Book title can not be empty." +
                    "\n\nEnter the title of the book: ");
            }

            Console.Write("Enter the author of the book: ");
            while((author = Console.ReadLine()) == "")
            {
                Console.Write("Error: Book author can not be empty." +
                    "\n\nIf you don't know who the author is, type anonymous: ");
            }

            Console.Write("\nEnter the number of copies: ");
            while (!(Int32.TryParse(Console.ReadLine(), out copies)) || copies < 1)
            {
                Console.Write("Error: Invalid input!" +
                    "\n\nPlease enter a number greater than 0: ");
            }
            
            return new Book(title, author, copies);
        }

        static int ReadChoice()
        {
            int choice;
            
            while(!(Int32.TryParse(Console.ReadLine(), out choice)) || (choice < 1 || choice > 5))
            {
                Console.Write("\nError: Invalid input!" +
                    "\nPlease choose a number from the list above: ");
            }
            return choice;
        }

        static void PrintOptions()
        {
            Console.Write("\n\n******************************");
            Console.Write("\nSelect an option:" +
                "\n\n1 - Quit" +
                "\n2 - Add a book" +
                "\n3 - Take out a book" +
                "\n4 - Return a book" +
                "\n5 - List all books" +
                "\n\nPlease enter an option: ");
        }
    }
}
