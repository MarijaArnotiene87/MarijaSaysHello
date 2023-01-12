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
                Name = "Mint",
                Colour = "blue",
                Flavour = "fresh",
                Odor = "menthol",
                BestPlantingMonth = "march",
                GrowingTimeInWeeks = 4,
                MinWeight = 10,
                MaxWeight = 50
            };
            mintHerb.MaxWeight += 5;
            Console.WriteLine($"{mintHerb.Name} average weight is {mintHerb.GetAverageWeight()}");
            mintHerb.PrintGrowInfo();

            var basilHerb = new Herb
            {
                Name = "Basil",
                Colour = "violet",
                Flavour = "savory",
                Odor = "sweet",
                BestPlantingMonth = "february",
                GrowingTimeInWeeks = 3,
                MinWeight = 8,
                MaxWeight = 60
            };
            basilHerb.MinWeight = 4;
            basilHerb.PrintOdorAndFlavour();
            basilHerb.PrintPlantInfo();

            var cherryTree = new Tree
            {
                Name = "Cherry",
                Colour = "white",
                BarkColour = "dark brown",
                HasBark = true,
                BestPlantingMonth = "may",
                GrowingTimeInWeeks = 60,
                MinHeight = 12,
                MaxHeight = 500
            };
            cherryTree.GrowingTimeInWeeks = 65;
            Console.WriteLine($"{cherryTree.Name} average height is {cherryTree.GetAverageHeight()}");
            cherryTree.PrintPlantInfo();

            var sequoiasTree = new Tree
            {
                Name = "Sequoia",
                Colour = "Light green",
                BarkColour = "medium brown",
                HasBark = true,
                BestPlantingMonth = "april",
                GrowingTimeInWeeks = 200,
                MinHeight = 9,
                MaxHeight = 300
            };
            sequoiasTree.PrintBarkInfo();
            sequoiasTree.BestPlantingMonth = "may";
            sequoiasTree.PrintGrowInfo();

            Console.WriteLine("**********************************");

            WildAnimal wildAnimal = new WildAnimal();
            var minHeight = IJump.minHeight;
            wildAnimal.Jump();
            wildAnimal.Run();
            Console.WriteLine(wildAnimal.JumpOnTree);
            Console.WriteLine(wildAnimal.Route);
            Console.WriteLine($"Wild animal min height {minHeight} m ");

            Console.WriteLine("**********************************");

            Pet petAnimal = new Pet();
            var averageSpeed = IRun.AverageSpeed;
            petAnimal.Jump();
            petAnimal.Run();
            Console.WriteLine(petAnimal.JumpOnTree);
            Console.WriteLine(petAnimal.Route);
            Console.WriteLine($"Pet average speed {averageSpeed} km/h ");
        }
    }
}