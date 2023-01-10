namespace Homework7.Task3
{
    public class MobilePhone : DeviceWithCamera, IPhoto
    {
        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price) : base(modelName, price, numberOfPixelsInCamera)
        {
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press left side button");
        }

    }
}
