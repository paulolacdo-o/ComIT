using System;
using System.Collections.Generic;
using System.Text;

namespace SimpLibrary
{
    class Book
    {
        public string title;
        public string author;
        public int copies;
        public int copiesLent;

        public Book()
        {
        }

        public Book(string title, string author, int copies)
        {
            this.title = title;
            this.author = author;
            this.copies = copies;
            copiesLent = 0;
        }

        public bool Loan()
        {
            bool isLent = false;

            if (copiesLent < copies)
            {
                isLent = true;
                copiesLent++;
            }

            return isLent;
        }

        public bool Return()
        {
            bool isReturned = false;

            if (copiesLent > 0)
            {
                isReturned = true;
                copiesLent--;
            }

            return isReturned;
        }

        override public string ToString()
        {
            return ($"{title}, by {author}. {copiesLent} copies lent out from {copies} total.");
        }
    }
}
