namespace Homework7.Task3
{
    public abstract class DeviceWithCamera : Device
    {
        private protected double numberOfPixelsInCamera;

        protected DeviceWithCamera(string? modelName, decimal price, double numberOfPixelsInCamera) : base(modelName, price)
        {
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public string Description { get => $"Price: {Price}, model:{ModelName}, number of pixels in camera: {numberOfPixelsInCamera}"; }
    }
}
