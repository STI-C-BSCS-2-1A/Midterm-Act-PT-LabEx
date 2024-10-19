namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            item_discount = discount * 0.01;
            discounted_price = item_price * (1 - item_discount);
        }

        public new double GetTotalPrice()
        {
            return discounted_price * item_quantity;
        }

        public void SetPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - GetTotalPrice();
        }

        public double GetChange()
        {
            return change;
        }
    }
}
