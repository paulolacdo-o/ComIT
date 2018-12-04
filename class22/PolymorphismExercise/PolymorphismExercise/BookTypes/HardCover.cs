using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismExercise.BookTypes
{
    class HardCover : Book
    {
        public HardCover(string title, string author, int numberOfPages) : base(title, author, numberOfPages)
        {
            SetManufacturingCost(5m + 0.03m * numberOfPages);
        }
    }
}
