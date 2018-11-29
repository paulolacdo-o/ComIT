using System;
using System.Collections.Generic;
using System.Text;

namespace PoS
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
