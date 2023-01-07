using MyShopLibrary;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company optioCompany = new Company("Optio", 1900, "LT001");
            optioCompany.PrintCompanyName();

            Company dellCompany = new Company("Dell", 2015, "LT002");
            dellCompany.PrintCompanyName();

            Shop seikShop = new Shop("Seik accossories", 2015, 5, "Vilnius");
            Company seikCompany = new Company("Seik", 2014, seikShop, "LT003");
            seikCompany.PrintAllShops();

            Shop knygynasShop = new Shop("Svajoniu knygu knygynas", 2020);
            Company svajoniuCompany = new Company("Svajoniu knygos", 2019, knygynasShop, "LT004");
            svajoniuCompany.PrintAllShops();

            Shop briedisFirstShop = new Shop("Briedis knygynas", 2017, 3, "Kaunas");
            Shop briedisSecondShop = new Shop("Briedis leidykla", 2018, 4, "Klaipeda");
            Shop briedisThirdShop = new Shop("Briedis pagrindinis knygynas", 2019, 9, "Kaunas");
            Shop[] shops = new Shop[] { briedisFirstShop, briedisSecondShop, briedisThirdShop };
            Company briedisCompany = new Company("Leidykla briedis", 2016, shops, "LT005");
            briedisCompany.PrintAllShops();
            briedisCompany.PrintCompanyEmployeesCountByCity("Kaunas");

            //Static method
            Company.PrintMinimumCarCount();

            Shop baltoShop = new Shop("Balto parduotuve", 2014, 2, "Vilnius");
            UABCompany baltoUABCompany = new UABCompany("Balto", 2012, "LT006", "Deividas");
            baltoUABCompany.AddShop(baltoShop);
            baltoUABCompany.PrintCompanyEmployeesCountByCity("Vilnius");
            Console.WriteLine(baltoUABCompany.GetCompanyInfo());
            baltoUABCompany.PrintCompanyName();

            //Upcasting
            Company baltoCompany = baltoUABCompany;

            //Downcasting
            Company almaLiteraCompany = new Company("Alma Litera", 2020, "LT007");
            //UABCompany almaLiteraUABCompany = (UABCompany)almaLiteraCompany; ------> sprosit v chiom problema, vikidivaet Exception
            UABCompany? almaLiteraUABCompany = almaLiteraCompany as UABCompany;
        }
    }
}