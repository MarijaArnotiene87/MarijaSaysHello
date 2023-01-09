using MyShopLibrary;

namespace MainProject
{
    public class Company
    {
        private Shop[] shops;
        public readonly string vatNumber;

        public string Name { get; private set; }

        public int FoundationYear { get; private set; }

        public Shop[] Shops
        {
            get { return shops; }
            private set { shops = value; }
        }

        public static int MinimumCarCount { get; private set; }

        public Company(string name, int year, string vatNumber)
        {
            Name = name;
            FoundationYear = year;
            this.vatNumber = vatNumber;
        }

        public Company(string name, int year, Shop shop, string vatNumber)
        {
            Name = name;
            FoundationYear = year;
            Shops = new[] { shop };
            this.vatNumber = vatNumber;
        }

        public Company(string name, int year, Shop[] shops, string vatNumber)
        {
            Name = name;
            FoundationYear = year;
            Shops = shops;
            this.vatNumber = vatNumber;
        }

        static Company()
        {
            MinimumCarCount = 2;
        }

        public virtual string GetCompanyInfo() => $"Company {Name} was established in {FoundationYear} and VAT number {vatNumber}";

        public void PrintCompanyName() => Console.WriteLine($"Company name is {Name}");

        public int GetShopCount() => Shops.Length;

        public void AddShop(Shop shop)
        {
            if (shops == null)
            {
                shops = new[] { shop };
            }
            else
            {
                Array.Resize(ref shops, shops.Length + 1);
                shops[shops.Length - 1] = shop;
            }
        }

        public void AddShop(string shopName, int year)
        {
            Shop shop = new Shop(shopName, year);
            Array.Resize(ref shops, shops.Length + 1);
            shops[shops.Length - 1] = shop;
        }

        public void PrintAllShops()
        {
            foreach (Shop shop in shops)
            {
                shop.PrintShopName();
            }
        }

        public virtual void PrintCompanyEmployeesCountByCity(string city)
        {
            int companyEmployeeCount = 0;
            foreach (Shop shop in shops)
            {
                if (shop.City == city)
                {
                    companyEmployeeCount += shop.EmployeeCount;
                }
            }

            Console.WriteLine($"Count of shops employees: {companyEmployeeCount}");
        }

        public static void PrintMinimumCarCount()
        {
            Console.WriteLine($"Minimum car count for openning company is: {MinimumCarCount}");
        }

    }
}
