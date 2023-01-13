using Homework10.LinkedList;
using Homework10.List;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { };
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            TaskList.SumOfAllEvenNumbers(numbers);

            var words = new List<string>() { "System", "Visa", "Loading", "Optimized", "Debug" };

            Console.WriteLine("Enter a length of search term :");
            var searchLength = Console.ReadLine();

            TaskList.PrintFiveLetterWord(words, int.Parse(searchLength));

            var items = new LinkedList<int>(new[] { 2, 4, 3, 2, 8, 2, 5, 1, 2 });
            var firstItem = 2;
            var secondItem = 7;
            TaskLinkedList.InsertItems(items, firstItem, secondItem);

            var list1 = new LinkedList<int>(new[] { 1, 3, 4, 7, 12 });
            var list2 = new LinkedList<int>(new[] { 1, 5, 7, 9 });
            TaskLinkedList.MergeLinkedLists(list1, list2);

            Queue<int> queue = new Queue<int>();
            string userInput;
            do
            {
                userInput = Console.ReadLine();
                int userInputValue;

                var isParsable = int.TryParse(userInput, out userInputValue);
                if (isParsable)
                {
                    queue.Enqueue(userInputValue);
                }
            } while (!string.IsNullOrWhiteSpace(userInput));
            TaskQueue.TaskQueue.Queue = queue;
            TaskQueue.TaskQueue.GetMaxValue();
            TaskQueue.TaskQueue.DeleteMaxValue();

            Stack<string> stack = new Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            var stackCount = stack.Count();
            for (int i = 0; i < stackCount; i++)
            {
                Console.WriteLine(stack.Pop());
            }
        }

    }
}