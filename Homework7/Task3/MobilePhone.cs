namespace Homework7.Task3
{
    public class MobilePhone : Device, IPhoto
    {
        public double NumberOfPixelsInCamera { get; set; }

        public new string Description { get => $"Price: {Price}, model:{ModelName}, number of pixels in camera: {NumberOfPixelsInCamera}"; }

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price)
        {
            NumberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public void TakePhoto() => Console.WriteLine("Press button on the screen and photo is ready");

        public override void TurnOn() => Console.WriteLine("Press left side button");

    }
}
