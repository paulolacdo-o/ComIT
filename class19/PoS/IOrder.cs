namespace PoS
{
    interface IOrder
    {
        void SetOrder(int orderNum, int num, string name, Item[] items, int numOfItems);
        decimal CalculateNetTotal();
        decimal CalculateGST();
        decimal CalculatePST();
        decimal CalculateFinalTotal();
    }
}
