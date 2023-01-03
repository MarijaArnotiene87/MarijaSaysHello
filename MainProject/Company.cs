using MyShopLibrary;

namespace MainProject
{
    public class Company
    {
        //In the main project also create a class with fields, methods. One of the fields must have a class type from the included library.
        //Use multiple constructors - with different number and type of parameters. In the Main method, create several objects of the main
        //project class using various constructors and initializers. Use object methods to write some information to the console.

        public string name;
        public int foundationYear;
        public Shop[] shops;

        public Company()
        {
        }

        public Company(string name, int year)
        {
            this.name = name;
            this.foundationYear = year;
        }

        public Company(string name, int year, Shop shop)
        {
            this.name = name;
            this.foundationYear = year;
            this.shops = new[] { shop };
        }

        public Company(string name, int year, Shop[] shops)
        {
            this.name = name;
            this.foundationYear = year;
            this.shops = shops;
        }

        public string GetCompanyInfo()
        {
            return $"Company {name} was established in {foundationYear}";
        }

        public void PrintCompanyName()
        {
            Console.WriteLine($"Company name is {name}");
        }

        public int GetShopCount()
        {
            return shops.Length;
        }

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

        public void DisplayAllShops()
        {
            foreach (Shop shop in shops)
            {
                shop.PrintShopName();
            }
        }

        public void DisplayCompanyEmployeesCount()
        {
            int companyEmployeeCount = 0;

            foreach (Shop shop in shops)
            {
                companyEmployeeCount += shop.employeeCount;
            }
            Console.WriteLine($"Count of shops employees: {companyEmployeeCount}");
        }
    }
}
