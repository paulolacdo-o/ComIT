using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
        	string itemName;
        	double taxRate, totalAmtOwed, moneyRcvd, change, itemPrice;
            bool isInsufficient = true;
            string temp;

            itemName = "unidentified item";
            taxRate = totalAmtOwed = moneyRcvd = change = itemPrice = 0;

            Console.WriteLine("ShoppingCart");
            Console.WriteLine("by Paulo");

            Console.WriteLine("\nPlease enter the item name:");
            itemName = Console.ReadLine();

            Console.WriteLine("\nPlease enter the item price:");
            if ((temp = Console.ReadLine()) != "")
            {
                itemPrice = Convert.ToDouble(temp);
            }

            Console.WriteLine("\nPlease enter the tax rate:");
            taxRate = getTaxRate();

            totalAmtOwed = itemPrice * (1.0 + taxRate);

            Console.WriteLine("\n\nYou are buying:");
            Console.WriteLine("\n" + itemName);
            Console.WriteLine("$ {0:C2}", itemPrice);
            Console.WriteLine("$ {0:C2}", (itemPrice * taxRate));
            Console.WriteLine("$ {0:C2}", totalAmtOwed);

            while (isInsufficient)
            {
                Console.WriteLine("\nEnter an amount of money to pay with:");
                if ((temp = Console.ReadLine()) != "")
                {
                    moneyRcvd = Convert.ToDouble(temp);
                }
                if (moneyRcvd < totalAmtOwed)
                {
                    Console.WriteLine("The amount you entered is insufficient. Please try again.");
                }
                else
                {
                    isInsufficient = false;
                }
            }

            change = moneyRcvd - totalAmtOwed;

            Console.WriteLine("\nReceived $ {0:C2}", moneyRcvd);
            Console.WriteLine("Your change is $ {0:C2}", change);

            Console.WriteLine("\nThank you for visiting the store!");

            WaitForEnd();
        }

        static double getTaxRate()
        {
            double taxRate = 0;
            string temp;

            if ((temp = Console.ReadLine()) != "")
            {
                taxRate = Convert.ToDouble(temp);
                if (taxRate >= 1)
                {
                    taxRate /= 100.0;
                }
            }
            return taxRate;
        }

        static void WaitForEnd()
        {
        	Console.WriteLine("\nPress enter to end.");
        	Console.Read();
        }
    }
}
