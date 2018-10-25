using System;
using System.Collections.Generic;
using System.Text;

namespace SimpLibrary
{
    class Book
    {
        public string Title;
        public string Author;
        public int Copies;
        public int CopiesLent;

        public Book()
        {
            Title = "Untitled";
            Author = "Anonymous";
            Copies = 1;
            CopiesLent = 0;
        }

        public Book(string title, string author, int copies)
        {
            Title = title;
            Author = author;
            Copies = copies;
            CopiesLent = 0;
        }

        public bool Loan()
        {
            bool isLent = false;

            if (CopiesLent < Copies)
            {
                isLent = true;
                CopiesLent++;
            }

            return isLent;
        }

        public bool Return()
        {
            bool isReturned = false;

            if (CopiesLent > 0)
            {
                isReturned = true;
                CopiesLent--;
            }

            return isReturned;
        }

        override public string ToString()
        {
            return ($"{Title}, by {Author}. {CopiesLent} copies lent out from {Copies} total.");
        }
    }
}
