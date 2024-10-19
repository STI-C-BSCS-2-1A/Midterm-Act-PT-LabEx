namespace ItemNamespace
{
    public class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
            total_price = item_price * item_quantity;
        }

        public double GetTotalPrice()
        {
            return total_price;
        }

        public void SetPayment(double amount)
        {
            // Implementation for setting payment
        }
    }
}
