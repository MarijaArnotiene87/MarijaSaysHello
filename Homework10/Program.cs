using Homework10.List;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { };
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            TaskList.SumOfAllEvenNumbers(numbers);

            List<string> words = new List<string>() { "System", "Visa", "Loading", "Optimized", "Debug" };

            Console.WriteLine("Enter a length of search term :");
            var searchLength = Console.ReadLine();

            TaskList.PrintFiveLetterWord(words, int.Parse(searchLength));
        }
    }
}