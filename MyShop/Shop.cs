namespace MyShopLibrary
{
    public class Shop
    {
        public string shopName;
        public int openingYear;
        public int employeeCount;
        public string city;

        public Shop(string name, int year)
        {
            this.shopName = name;
            this.openingYear = year;
            this.employeeCount = 1;
            this.city = "unknown";
        }

        public Shop(string name, int year, int employeeCount, string city)
        {
            this.shopName = name;
            this.openingYear = year;
            this.employeeCount = employeeCount;
            this.city = city;
        }

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