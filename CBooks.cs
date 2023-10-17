namespace BookShopManager
{
    public class CBooks
    {
        private string title;
        private string author;
        private string cate;
        private int price;
        private int qty;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Cate { get => cate; set => cate = value; }
        public int Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }
    }
}
