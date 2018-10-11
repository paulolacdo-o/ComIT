using System;

namespace ShoppingCartV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();

            Console.WriteLine("Please enter the item name:");
            item.setItemName(Console.ReadLine());

            Console.WriteLine("Please enter the item price:");
            item.setItemPrice(Console.ReadLine());

            Console.WriteLine("Please enter the tax rate:");
            item.setTaxRate(Console.ReadLine());

            Console.WriteLine("You are buying:");
            Console.WriteLine("Item: " + item.getItemName());
            Console.WriteLine("Price: $ {0:0.##}", item.getItemPrice());
            Console.WriteLine("Tax: $ {0:0.##}", item.getItemPrice() * item.getTaxRate());
            Console.WriteLine("Total: $ {0:0.##}", item.getTotalAmtOwed());

            Console.WriteLine("Please enter amount to pay with:");
            while(!item.setAmtRcvd(Console.ReadLine()))
            {
                Console.WriteLine("Not enough. Please try again.");
            }

            Console.WriteLine("Transaction completed:");
            Console.WriteLine("Received: $ {0:0.##}", item.getAmtRcvd());
            Console.WriteLine("Change: $ {0:0.##}", item.getChange());
            Console.WriteLine("Thank you for the purchase! Please come again. :)");

            Console.WriteLine("Press [Enter] key to end program.");
            Console.Read();
        }
    }

    class Item
    {
        private string itemName;
        private decimal itemPrice;
        private decimal taxRate;
        private decimal totalAmtOwed;
        private decimal amtRcvd;
        private decimal amtChange;

        public Item()
        {
            itemName = "Unknown Item";
            itemPrice = taxRate = totalAmtOwed = amtRcvd = amtChange = 0;

        }

        public void setItemName(string name)
        {
            itemName = name;
        }

        public void setItemPrice(string price)
        {
            if (price != "")
            {
                itemPrice = Convert.ToDecimal(price);
            }
        }

        public void setTaxRate(string tax)
        {
            if (tax != "")
            {
                decimal temp = Convert.ToDecimal(tax);
                if (temp >= 1)
                {
                    taxRate = temp / 100;
                }
                else
                {
                    taxRate = temp;
                }
            }
            totalAmtOwed = itemPrice * (1 + taxRate);
        }

        public bool setAmtRcvd(string amt)
        {
            if (amt != "")
            {
                decimal temp = Convert.ToDecimal(amt);
                if (temp < totalAmtOwed)
                {
                    return false;
                }
                else
                {
                    amtRcvd = temp;
                    amtChange = amtRcvd - totalAmtOwed;
                    return true;
                }
            }
            else
            {
                amtRcvd = 0;
                amtChange = amtRcvd - totalAmtOwed;
                return false;
            }
        }

        public string getItemName()
        {
            return itemName;
        }

        public decimal getItemPrice()
        {
            return itemPrice;
        }

        public decimal getTaxRate()
        {
            return taxRate;
        }

        public decimal getAmtRcvd()
        {
            return amtRcvd;
        }

        public decimal getChange()
        {
            return amtChange;
        }

        public decimal getTotalAmtOwed()
        {
            return totalAmtOwed;
        }
    }
}
