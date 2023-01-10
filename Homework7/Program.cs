using Homework7.Task1;
using Homework7.Task2;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine($"{mintHerb.name} average weight is {mintHerb.getAverageWeight()}");
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
            Console.WriteLine($"{cherryTree.name} average height is {cherryTree.getAverageHeight()}");
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

            Console.WriteLine("**********************************");

            WildAnimal wildAnimal = new WildAnimal();
            var minHeight = IJump.minHeight;
            wildAnimal.Jump();
            wildAnimal.Run();
            Console.WriteLine(wildAnimal.JumpOnTree);
            Console.WriteLine(wildAnimal.route);
            Console.WriteLine($"Wild animal min height {minHeight} m ");

            Console.WriteLine("**********************************");

            Pet petAnimal = new Pet();
            var averageSpeed = IRun.averageSpeed;
            petAnimal.Jump();
            petAnimal.Run();
            Console.WriteLine(petAnimal.JumpOnTree);
            Console.WriteLine(petAnimal.Route);
            Console.WriteLine($"Pet average speed {averageSpeed} km/h ");
        }
    }
}