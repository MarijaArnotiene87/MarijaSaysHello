namespace Homework7.Task3
{
    public class Polaroid : DeviceWithCamera, IPrint, IPhoto
    {
        private int paperWidth;
        private int paperHeight;

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price, numberOfPixelsInCamera)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }

    }
}
