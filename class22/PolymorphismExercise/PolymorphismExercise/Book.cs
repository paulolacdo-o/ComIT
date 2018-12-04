using System;

namespace PolymorphismExercise
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int NumberOfPages { get; private set; }
        public decimal ManufacturingCost { get; private set; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public void SetManufacturingCost(decimal cost)
        {
            ManufacturingCost = cost;
        }
        
        public void PrintBookInformation()
        {
            Console.WriteLine($"Title: {Title}\n\tAuthor: {Author}\n\tPages: {NumberOfPages}\n\tManufacturing Cost: {ManufacturingCost:C}");
        }
    }
}
