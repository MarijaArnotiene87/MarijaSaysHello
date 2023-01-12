namespace Homework7.Task3
{
    public class Printer : Device, IPrint
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight) : base(modelName, price)
        {
            PaperWidth = paperWidth;
            PaperHeight = paperHeight;
        }

        public void Print() => Console.WriteLine("Printing...");

        public override void TurnOn() => Console.WriteLine("Press button at the top");
    }
}
