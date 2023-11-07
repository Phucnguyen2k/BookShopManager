namespace BookShopManager
{
    public class CBooks
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

        public int Year { get; set; }

        public static string[] Cate = new string[]
        {
            "Programming",
            "Novels",
            "Light Novel",
            "Nofiction",
            "Self-Help"
        };
    }
}
