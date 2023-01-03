using MyShopLibrary;

namespace MainProject
{
    public class Company
    {
        public string name;
        public int foundationYear;
        public Shop[] shops;

        public Company()
        {
        }

        public Company(string name, int year)
        {
            this.name = name;
            foundationYear = year;
        }

        public Company(string name, int year, Shop shop)
        {
            this.name = name;
            foundationYear = year;
            shops = new[] { shop };
        }

        public Company(string name, int year, Shop[] shops)
        {
            this.name = name;
            foundationYear = year;
            this.shops = shops;
        }

        public string GetCompanyInfo() => $"Company {name} was established in {foundationYear}";

        public void PrintCompanyName() => Console.WriteLine($"Company name is {name}");

        public int GetShopCount() => shops.Length;

        public void AddShop(Shop shop)
        {
            Array.Resize(ref shops, shops.Length + 1);
            shops[shops.Length - 1] = shop;
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

        public void PrintCompanyEmployeesCountByCity(string city)
        {
            int companyEmployeeCount = 0;
            foreach (Shop shop in shops)
            {
                if (shop.city == city)
                {
                    companyEmployeeCount += shop.employeeCount;
                }
            }

            Console.WriteLine($"Count of shops employees: {companyEmployeeCount}");
        }

    }
}
