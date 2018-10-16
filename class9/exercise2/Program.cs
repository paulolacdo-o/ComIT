using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ORIGINAL = 0, TAXED = 1;
            const decimal TAX_RATE = 0.13m;

            Console.Write("Enter the number of items in your shopping cart: ");

            int numberOfItems = ReadNumberOfItems();
            decimal[,] itemPrice = new decimal[numberOfItems, 2];

            for (int i = 0; i < numberOfItems; i++)
            {
                Console.Write($"Enter the price of item {i + 1}: $");
                itemPrice[i, ORIGINAL] = ReadItemPrice();
                itemPrice[i, TAXED] = itemPrice[i, ORIGINAL] * (1 + TAX_RATE);
            }
            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"The price with tax on item {i + 1} is: {itemPrice[i, TAXED]:C2}");
            }

            WaitForEnterKey();
        }

        static decimal ReadItemPrice()
        {
            decimal num;

            while(!(Decimal.TryParse(Console.ReadLine(), out num)))
            {
                Console.Write("Invalid value. Try again. ");
            }

            return num;
        }

        static int ReadNumberOfItems()
        {
            int num;

            while(!(Int32.TryParse(Console.ReadLine(), out num)))
            {
                Console.Write("Invalid value. Try again. ");
            }

            return num;
        }

        static void WaitForEnterKey()
        {
            Console.WriteLine("Press [Enter] key to exit program.");
            Console.ReadLine();
        }
    }
}
