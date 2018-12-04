using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercise.BookTypes
{
    class PaperBack : Book
    {
        public PaperBack(string title, string author, int numberOfPages) : base(title, author, numberOfPages)
        {
            SetManufacturingCost(numberOfPages * 0.02m);
        }
    }
}
