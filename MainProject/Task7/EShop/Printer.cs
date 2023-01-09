using MainProject.Task7.EShop;

namespace AutomationCources.Lecture_7.Homework
{
    public class Printer : Device, IPrint
    {
        private int paperWidth;
        private int paperHeight;

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight) : base (modelName, price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}";
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }
}
}
