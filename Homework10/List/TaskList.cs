namespace Homework10.List
{
    public static class TaskList
    {
        public static void SumOfAllEvenNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }

        public static void PrintFiveLetterWord(List<string> words, int searchLength)
        {
            foreach (var word in words)
            {
                if (word.Length == searchLength)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
