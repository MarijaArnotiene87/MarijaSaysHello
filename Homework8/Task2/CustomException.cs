namespace Homework8.Task2
{
    public class CustomException : Exception
    {
        public int CustomInt { get; set; }
        public string CustomString { get; set; }

        public CustomException(string message, int customInt, string customString) : base(message)
        {
            CustomInt = customInt;
            CustomString = customString;
        }
    }
}
