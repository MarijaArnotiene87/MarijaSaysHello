using MainProject.Task7;
using MyShopLibrary;

namespace MainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var optioCompany = new Company("Optio", 1900, "LT001");
            optioCompany.PrintCompanyName();

            var dellCompany = new Company("Dell", 2015, "LT002");
            dellCompany.PrintCompanyName();

            var seikShop = new Shop("Seik accossories", 2015, 5, "Vilnius");
            var seikCompany = new Company("Seik", 2014, seikShop, "LT003");
            seikCompany.PrintAllShops();
            seikShop.GetShopInfo();

            var knygynasShop = new Shop("Svajoniu knygu knygynas", 2020);
            var svajoniuCompany = new Company("Svajoniu knygos", 2019, knygynasShop, "LT004");
            svajoniuCompany.PrintAllShops();

            var briedisFirstShop = new Shop("Briedis knygynas", 2017, 3, "Kaunas");
            var briedisSecondShop = new Shop("Briedis leidykla", 2018, 4, "Klaipeda");
            var briedisThirdShop = new Shop("Briedis pagrindinis knygynas", 2019, 9, "Kaunas");
            var shops = new Shop[] { briedisFirstShop, briedisSecondShop, briedisThirdShop };
            var briedisCompany = new Company("Leidykla briedis", 2016, shops, "LT005");
            briedisCompany.PrintAllShops();
            briedisCompany.PrintCompanyEmployeesCountByCity("Kaunas");

            //Static method
            Company.PrintMinimumCarCount();

            var baltoShop = new Shop("Balto parduotuve", 2014, 2, "Vilnius");
            var baltoUABCompany = new UABCompany("Balto", 2012, "LT006", "Deividas");
            baltoUABCompany.AddShop(baltoShop);
            baltoUABCompany.PrintCompanyEmployeesCountByCity("Vilnius");
            Console.WriteLine(baltoUABCompany.GetCompanyInfo());
            baltoUABCompany.PrintCompanyName();

            //Downcasting
            var almaLiteraCompany = new Company("Alma Litera", 2020, "LT007");
            //var almaLiteraUABCompany = (UABCompany)almaLiteraCompany; ------> sprosit v chiom problema, vikidivaet Exception


            //Task 7
            var mintHerb = new Herb
            {
                name = "Mint",
                Colour = "blue",
                flavour = "fresh",
                odor = "menthol",
                bestPlantingMonth = "march",
                GrowingTimeInWeeks = 4,
                minWeight = 10,
                maxWeight = 50
            };
            mintHerb.maxWeight += 5;
            Console.WriteLine(mintHerb.getAverageWeight());
            mintHerb.PrintGrowInfo();

            var basilHerb = new Herb
            {
                name = "Basil",
                Colour = "violet",
                flavour = "savory",
                odor = "sweet",
                bestPlantingMonth = "february",
                GrowingTimeInWeeks = 3,
                minWeight = 8,
                maxWeight = 60
            };
            basilHerb.minWeight = 4;
            basilHerb.PrintOdorAndFlavour();
            basilHerb.PrintPlantInfo();

            var cherryTree = new Tree
            {
                name = "Cherry",
                Colour = "white",
                barkColour = "dark brown",
                hasBark = true,
                bestPlantingMonth = "may",
                GrowingTimeInWeeks = 60,
                minHeight = 12,
                maxHeight = 500
            };
            cherryTree.GrowingTimeInWeeks = 65;
            Console.WriteLine(cherryTree.getAverageHeight());
            cherryTree.PrintPlantInfo();

            var sequoiasTree = new Tree
            {
                name = "Sequoia",
                Colour = "Light green",
                barkColour = "medium brown",
                hasBark = true,
                bestPlantingMonth = "april",
                GrowingTimeInWeeks = 200,
                minHeight = 9,
                maxHeight = 300
            };
            sequoiasTree.PrintBarkInfo();
            sequoiasTree.bestPlantingMonth = "may";
            sequoiasTree.PrintGrowInfo();
        }
    }
}