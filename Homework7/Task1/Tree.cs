namespace Homework7.Task1
{
    public class Tree : Plant
    {
        public bool hasBark;
        public string barkColour;
        private int _growingTimeInWeeks;

        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }

        public override string Colour { get; set; }

        public override int GrowingTimeInWeeks { get => _growingTimeInWeeks + 1; set => _growingTimeInWeeks = value; }

        public override void PrintGrowInfo()
        {
            Console.WriteLine($"Best planting month {bestPlantingMonth} and growing time in weeks {GrowingTimeInWeeks}");
        }

        public void PrintBarkInfo()
        {
            Console.WriteLine($"This plant {(hasBark ? "has" : "doesn't have")} bark and bark colour is {barkColour}");
        }

        public int GetAverageHeight()
        {
            return (MinHeight + MaxHeight) / 2;
        }
    }
}
