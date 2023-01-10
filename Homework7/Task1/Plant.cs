namespace Homework7.Task1
{
    public abstract class Plant
    {
        public string name;
        public string bestPlantingMonth;

        public abstract string Colour { get; set; }

        public abstract int GrowingTimeInWeeks { get; set; }

        public void PrintPlantInfo()
        {
            Console.WriteLine($"Some info about plant: name is {name} and colour is {Colour}");
        }

        public abstract void PrintGrowInfo();
    }
}
