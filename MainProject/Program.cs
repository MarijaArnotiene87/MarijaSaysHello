using MyShopLibrary;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company namaiCompany = new Company();

            Company optioCompany = new Company();
            optioCompany.name = "Optio";
            optioCompany.foundationYear = 1900;

            Company dellCompany = new Company { name = "Dell", foundationYear = 2015 };

            namaiCompany.PrintCompanyName();
            dellCompany.PrintCompanyName();
            optioCompany.PrintCompanyName();

            Shop seikShop = new Shop("Seik accossories", 2015, 5, "Vilnius");
            Company seikCompany = new Company("Seik", 2014, seikShop);

            Shop knygynasShop = new Shop("Svajoniu knygu knygynas", 2020);
            Company svajoniuCompany = new Company("Svajoniu knygos", 2019, knygynasShop);

            Shop briedisFirstShop = new Shop("Briedis knygynas", 2017, 3, "Kaunas");
            Shop briedisSecondShop = new Shop("Briedis leidykla", 2018, 4, "Klaipeda");
            Shop[] shops = new Shop[] { briedisFirstShop, briedisSecondShop };
            Company briedisCompany = new Company("Leidykla briedis", 2016, shops);

            briedisCompany.DisplayAllShops();
            svajoniuCompany.DisplayAllShops();
            seikCompany.DisplayAllShops();
            briedisCompany.DisplayCompanyEmployeesCount();
        }
    }
}