namespace Homework8.Task2
{
    public class ExceptionGenerator
    {
        public void GenerateException()
        {
            throw new CustomException("Custom error happened", 52, "Some string");
        }

    }
}
