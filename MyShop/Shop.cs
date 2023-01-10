namespace MyShopLibrary
{
    public class Shop
    {
        public string ShopName { get; private set; }

        public int OpeningYear { get; private set; }

        public int EmployeeCount { get; private set; }

        public string City { get; private set; }

        public Shop(string name, int year) : this(name, year, 1, "unknown")
        { }

        public Shop(string name, int year, int employeeCount, string city)
        {
            ShopName = name;
            OpeningYear = year;
            EmployeeCount = employeeCount;
            City = city;
        }

        public string GetShopInfo() => $"Shop {ShopName} was opened in {OpeningYear}";

        public void PrintShopName() => Console.WriteLine($"Shop name is {ShopName}");

    }
}