using AutomationCources.Lecture_7.Homework;

namespace MainProject.Task7.EShop
{
    public abstract class DeviceWithCamera : Device
    {
        private protected double numberOfPixelsInCamera;

        protected DeviceWithCamera(string? modelName, decimal price, double numberOfPixelsInCamera) : base(modelName, price)
        {
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }
    }
}
