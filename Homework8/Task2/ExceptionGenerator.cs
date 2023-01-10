namespace Homework8.Task2
{
    public class ExceptionGenerator
    {
        public void GenerateException()
        {
            try
            {
                throw new CustomException("Custom error happened", 52, "Some string");
            }
            catch (CustomException ex)
            {
                Console.WriteLine($"Error message: {ex.Message}, customInt: {ex.CustomInt}, customString: {ex.CustomString} ");
            }
        }
    }
}
