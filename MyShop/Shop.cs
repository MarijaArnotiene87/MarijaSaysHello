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
            shopName = name;
            openingYear = year;
            employeeCount = 1;
            city = "unknown";
        }

        public Shop(string name, int year, int employeeCount, string city)
        {
            shopName = name;
            openingYear = year;
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