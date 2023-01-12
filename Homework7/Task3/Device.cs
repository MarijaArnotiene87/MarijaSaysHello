namespace Homework7.Task3
{
    public abstract class Device
    {
        private protected string ModelName { get; set; }

        private protected decimal Price { get; set; }

        public Device(string modelName, decimal price)
        {
            ModelName = modelName;
            Price = price;
        }

        public abstract void TurnOn();

        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
