namespace Homework8.Task1
{
    internal class MassiveElement
    {
        private static string? inputValue;

        public static void ShowMassiveElement()
        {
            int[] massive = { 8, 7, 1, 4, 2 };
            Console.WriteLine("Input index of element in massive:");
            string? inputedValue = Console.ReadLine();
            string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputValue;

            try
            {
                int inputtedNumber = int.Parse(checkedValue);
                int massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Bad argument: {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Out of range: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}
