namespace MyShopLibrary
{
    public class Shop
    {
        public string shopName;
        public int openingYear;

        public string GetShopInfo()
        {
            return $"Shop {shopName} was opened in {openingYear}";
        }

        public void PrintShopName()
        {
            Console.WriteLine($"Shop name is {shopName}");
        }
    }
}