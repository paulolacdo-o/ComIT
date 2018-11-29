using System;
using System.Collections.Generic;
using System.Text;

namespace PoS
{
    class Invoice : IOrder
    {
        public const decimal GST_RATE = 0.05m;
        public const decimal PST_RATE = 0.08m;
        public int InvoiceNumber { get; private set; }
        public int CustomerNumber { get; private set; }
        public string CustomerName { get; private set; }
        public Item[] Items { get; private set; }
        public decimal NetTotal { get; private set; }
        public decimal GST { get; private set; }
        public decimal PST { get; private set; }
        public decimal FinalTotal { get; private set; }

        public Invoice()
        {
        }

        public Invoice(int invoiceNumber, int customerNumber, string customerName, Item[] items, int numOfItems)
        {
            InvoiceNumber = invoiceNumber;
            CustomerNumber = customerNumber;
            CustomerName = customerName;
            SetItems(items, numOfItems);
        }

        private void SetItems(Item[] items, int numOfItems)
        {
            Items = new Item[numOfItems];
            for (int i = 0; i < Items.Length; i++)
            {
                Items[i] = items[i];
            }
        }

        public void SetOrder(int invoiceNumber, int customerNumber, string customerName, Item[] items, int numOfItems)
        {
            InvoiceNumber = invoiceNumber;
            CustomerNumber = customerNumber;
            CustomerName = customerName;
            SetItems(items, numOfItems);
        }

        public decimal CalculateNetTotal()
        {
            NetTotal = 0m;

            for (int i = 0; i < Items.Length; i++)
            {
                NetTotal += Items[i].Price;
            }

            return NetTotal;
        }

        public decimal CalculateGST()
        {
            GST = NetTotal * GST_RATE;
            return GST;
        }
        public decimal CalculatePST()
        {
            PST = NetTotal * PST_RATE;
            return PST;
        }
        public decimal CalculateFinalTotal()
        {
            FinalTotal = NetTotal - PST - GST;
            return FinalTotal;
        }
    }
}
