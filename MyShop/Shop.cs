namespace MyShopLibrary
{
    public class Shop
    {
        private string shopName;
        private int openingYear;
        private int employeeCount;
        private string city;

        public string ShopName
        {
            get { return shopName; }

            private set { shopName = value; }
        }

        public int OpeningYear
        {
            get { return openingYear; }

            private set { openingYear = value; }
        }

        public int EmployeeCount
        {
            get { return employeeCount; }

            private set { employeeCount = value; }
        }

        public string City
        {
            get { return city; }

            private set { city = value; }
        }

        public Shop(string name, int year)
        {
            ShopName = name;
            OpeningYear = year;
            EmployeeCount = 1;
            City = "unknown";
        }

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