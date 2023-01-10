using MyShopLibrary;

namespace MainProject
{
    public class Company
    {
        private Shop[] _shops;
        private readonly string _vatNumber;

        public string Name { get; private set; }

        public int FoundationYear { get; private set; }

        public Shop[] Shops
        {
            get { return _shops; }
            private set { _shops = value; }
        }

        public static int MinimumCarCount { get; private set; }

        public Company(string name, int year, string vatNumber)
        {
            Name = name;
            FoundationYear = year;
            _vatNumber = vatNumber;
        }

        public Company(string name, int year, Shop shop, string vatNumber)
        {
            Name = name;
            FoundationYear = year;
            Shops = new[] { shop };
            _vatNumber = vatNumber;
        }

        public Company(string name, int year, Shop[] shops, string vatNumber)
        {
            Name = name;
            FoundationYear = year;
            Shops = shops;
            _vatNumber = vatNumber;
        }

        static Company()
        {
            MinimumCarCount = 2;
        }

        public virtual string GetCompanyInfo() => $"Company {Name} was established in {FoundationYear} and VAT number {_vatNumber}";

        public void PrintCompanyName() => Console.WriteLine($"Company name is {Name}");

        public int GetShopCount() => Shops.Length;

        public void AddShop(Shop shop)
        {
            if (_shops == null)
            {
                _shops = new[] { shop };
            }
            else
            {
                Array.Resize(ref _shops, _shops.Length + 1);
                _shops[_shops.Length - 1] = shop;
            }
        }

        public void AddShop(string shopName, int year)
        {
            Shop shop = new Shop(shopName, year);
            Array.Resize(ref _shops, _shops.Length + 1);
            _shops[_shops.Length - 1] = shop;
        }

        public void PrintAllShops()
        {
            Console.WriteLine($"Company {Name} shops: ");
            foreach (Shop shop in _shops)
            {
                shop.PrintShopName();
            }

            Console.WriteLine();
        }

        public virtual void PrintCompanyEmployeesCountByCity(string city)
        {
            int companyEmployeeCount = 0;
            foreach (Shop shop in _shops)
            {
                if (shop.City == city)
                {
                    companyEmployeeCount += shop.EmployeeCount;
                }
            }

            Console.WriteLine($"Company {Name} has {companyEmployeeCount} employees in the {city} city");
        }

        public static void PrintMinimumCarCount()
        {
            Console.WriteLine($"Minimum car count for openning company is: {MinimumCarCount}");
        }

    }
}
