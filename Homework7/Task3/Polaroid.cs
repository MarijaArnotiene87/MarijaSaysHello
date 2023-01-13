namespace Homework7.Task3
{
    public class Polaroid : Device, IPrint, IPhoto
    {
        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public double NumberOfPixelsInCamera { get; set; }

        public new string Description { get => $"{base.Description}, number of pixels in camera: {NumberOfPixelsInCamera}"; }

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
            PaperWidth = paperWidth;
            PaperHeight = paperHeight;
            NumberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public void TakePhoto() => Console.WriteLine("Press black button at the top and photo is ready");

        public void Print() => Console.WriteLine("Printing...");

        public override void TurnOn() => Console.WriteLine("Press right side button");

    }
}
