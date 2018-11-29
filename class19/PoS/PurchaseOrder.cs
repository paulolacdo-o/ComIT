using System;
using System.Collections.Generic;
using System.Text;

namespace PoS
{
    class PurchaseOrder : IOrder
    {
        public const decimal GST_RATE = 0.05m;
        public const decimal PST_RATE = 0.08m;
        public int PurchaseOrderNumber { get; private set; }
        public int SupplierNumber { get; private set; }
        public string SupplierName { get; private set; }
        public Item[] Items { get; private set; }
        public decimal NetTotal { get; private set; }
        public decimal GST { get; private set; }
        public decimal PST { get; private set; }
        public decimal FinalTotal { get; private set; }

        public PurchaseOrder()
        {
        }

        public PurchaseOrder(int purchaseOrderNumber, int supplierNumber, string supplierName, Item[] items, int numOfItems)
        {
            PurchaseOrderNumber = purchaseOrderNumber;
            SupplierNumber = supplierNumber;
            SupplierName = supplierName;
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

        public void SetOrder(int purchaseOrderNumber, int supplierNumber, string supplierName, Item[] items, int numOfItems)
        {
            PurchaseOrderNumber = purchaseOrderNumber;
            SupplierNumber = supplierNumber;
            SupplierName = supplierName;
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
