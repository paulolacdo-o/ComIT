using System;

namespace PoS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            PressAnyKey();

            while (IsMenu()) ;

            Console.Clear();
            Console.WriteLine("Thank you for using our services!");
            PressAnyKey();
             
        }

        static bool IsMenu()
        {
            DisplayMenu();

            string input = Console.ReadLine();
            char choice = ' ';

            if (input != "")
                choice = input[0];

            switch(choice)
            {
                case 'i':
                case 'I':
                case '1':
                    Invoice invoice = new Invoice();
                    ReadOrder(invoice, OrderType.Invoice);
                    PrintOrder(invoice);
                    PressAnyKey();
                    break;
                case 'p':
                case 'P':
                case '2':
                    PurchaseOrder purchaseOrder = new PurchaseOrder();
                    ReadOrder(purchaseOrder, OrderType.PurchaseOrder);
                    PrintOrder(purchaseOrder);
                    PressAnyKey();
                    break;
                case 'q':
                case 'Q':
                case '3':
                    return false;
                default:
                    Console.WriteLine("Invalid Input: Please try again!");
                    PressAnyKey();
                    break;
            }

            return true;
        }

        static void PrintOrder(IOrder order)
        {
            Console.WriteLine($"Net Total... {order.CalculateNetTotal():C2}");
            Console.WriteLine($"GST......... {order.CalculateGST():C2}");
            Console.WriteLine($"PST......... {order.CalculatePST():C2}");
            Console.WriteLine($"Net Total... {order.CalculateFinalTotal():C2}");
        }

        static void ReadOrder(IOrder order, OrderType typeOfOrder)
        {
            Console.WriteLine();
            PrintDivider('*', 20);
            Console.Write("Enter "+(typeOfOrder==OrderType.Invoice?"Invoice":"Purchase Order")+" number: ");
            int orderNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter " + (typeOfOrder == OrderType.Invoice ? "Customer" : "Supplier") + " number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter " + (typeOfOrder == OrderType.Invoice ? "Customer" : "Supplier") + " name: ");
            string name = Console.ReadLine();

            int numOfItems;
            Item[] items = new Item[10];
            for (numOfItems = 0; numOfItems < 10; numOfItems++)
            {
                Console.WriteLine();
                Console.WriteLine($"Item Number {numOfItems + 1}. " + (numOfItems > 0 ? "Enter -1 for item name to end." : ""));
                Console.Write("Enter item name: ");
                string itemName = Console.ReadLine();
                if (itemName == "-1")
                {
                    
                    break;
                }

                Console.Write("Enter item price: ");
                decimal itemPrice = Convert.ToDecimal(Console.ReadLine());

                items[numOfItems] = new Item(itemName, itemPrice);
            }

            Console.WriteLine();
            order.SetOrder(orderNum, num, name, items, numOfItems);
        }

        static void DisplayMenu()
        {
            Console.Clear();
            PrintDivider('*', 20);
            Console.WriteLine("1. (I)nvoice");
            Console.WriteLine("2. (P)urchase Order");
            Console.WriteLine("3. (Q)uit");

        }

        static void PrintDivider(char symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        static void PressAnyKey()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
