namespace Homework7.Task1
{
    public class Herb : Plant
    {
        public string odor;
        public string flavour;
        private string _colour;

        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }

        public override string Colour { get => _colour + "/green"; set => _colour = value; }

        public override int GrowingTimeInWeeks { get; set; }

        public override void PrintGrowInfo()
        {
            Console.WriteLine($"Best planting month {bestPlantingMonth} and growing time in weeks {GrowingTimeInWeeks}");
        }

        public void PrintOdorAndFlavour()
        {
            Console.WriteLine($"Odor is {odor} and flavour like {flavour}");
        }

        public int GetAverageWeight()
        {
            return (MinWeight + MaxWeight) / 2;
        }
    }
}
