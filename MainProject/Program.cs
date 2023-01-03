using MyShopLibrary;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company optioCompany = new Company();
            optioCompany.name = "Optio";
            optioCompany.foundationYear = 1900;
            optioCompany.PrintCompanyName();

            Company dellCompany = new Company { name = "Dell", foundationYear = 2015 };
            dellCompany.PrintCompanyName();

            Shop seikShop = new Shop("Seik accossories", 2015, 5, "Vilnius");
            Company seikCompany = new Company("Seik", 2014, seikShop);
            seikCompany.PrintAllShops();

            Shop knygynasShop = new Shop("Svajoniu knygu knygynas", 2020);
            Company svajoniuCompany = new Company("Svajoniu knygos", 2019, knygynasShop);
            svajoniuCompany.PrintAllShops();

            Shop briedisFirstShop = new Shop("Briedis knygynas", 2017, 3, "Kaunas");
            Shop briedisSecondShop = new Shop("Briedis leidykla", 2018, 4, "Klaipeda");
            Shop briedisThirdShop = new Shop("Briedis pagrindinis knygynas", 2019, 9, "Kaunas");
            Shop[] shops = new Shop[] { briedisFirstShop, briedisSecondShop, briedisThirdShop };
            Company briedisCompany = new Company("Leidykla briedis", 2016, shops);
            briedisCompany.PrintAllShops();
            briedisCompany.PrintCompanyEmployeesCountByCity("Kaunas");
        }
    }
}