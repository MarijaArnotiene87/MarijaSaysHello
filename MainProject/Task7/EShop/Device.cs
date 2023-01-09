namespace AutomationCources.Lecture_7.Homework
{
    public abstract class Device
    {
        private string? modelName;
        private decimal price;

        private protected string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }

        private protected decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Device(string? modelName, decimal price)
        {
            this.modelName = modelName;
            this.price = price;
        }

        public abstract void TurnOn();

        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
