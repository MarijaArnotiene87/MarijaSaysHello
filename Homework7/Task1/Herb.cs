namespace Homework7.Task1
{
    public class Herb : Plant
    {
        public string Odor;
        public string Flavour;
        private string _colour;

        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }

        public override string Colour { get => _colour + "/green"; set => _colour = value; }

        public override int GrowingTimeInWeeks { get; set; }

        public override void PrintGrowInfo() => Console.WriteLine($"Best planting month {BestPlantingMonth} and growing time in weeks {GrowingTimeInWeeks}");

        public void PrintOdorAndFlavour() => Console.WriteLine($"Odor is {Odor} and flavour like {Flavour}");

        public int GetAverageWeight() => (MinWeight + MaxWeight) / 2;
    }
}
