namespace BookShopManager.Class
{
    public class CBill
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get { return Quantity * Price; } }

        public CBill()
        {
        }
        public CBill(string name, int quantity, int price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        private static int totalPrice = 0;

        public static int GetTotalPrice()
        {
            return totalPrice;
        }

        public static void AddToTotalPrice(int amount)
        {
            totalPrice += amount;
        }

    }
}
