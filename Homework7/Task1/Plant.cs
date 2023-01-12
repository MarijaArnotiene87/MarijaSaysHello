namespace Homework7.Task1
{
    public abstract class Plant
    {
        public string Name;
        public string BestPlantingMonth;

        public abstract string Colour { get; set; }

        public abstract int GrowingTimeInWeeks { get; set; }

        public void PrintPlantInfo()
        {
            Console.WriteLine($"Some info about plant: name is {Name} and colour is {Colour}");
        }

        public abstract void PrintGrowInfo();
    }
}
