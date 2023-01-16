using Homework10.Dictionary;
using Homework10.LinkedList;
using Homework10.List;

namespace Homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TasksForList();
            TasksForLinkedList();
            TasksForQueue();
            TasksForStack();
            TasksForDictionary();
        }

        static void TasksForList()
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
        }

        static void TasksForLinkedList()
        {
            var items = new LinkedList<int>(new[] { 2, 4, 3, 2, 8, 2, 5, 1, 2 });
            var firstItem = 2;
            var secondItem = 7;
            TaskLinkedList.InsertItems(items, firstItem, secondItem);

            var list1 = new LinkedList<int>(new[] { 1, 3, 4, 7, 12 });
            var list2 = new LinkedList<int>(new[] { 1, 5, 7, 9 });
            TaskLinkedList.MergeLinkedLists(list1, list2);
        }

        static void TasksForQueue()
        {
            var queue = new Queue<int>();
            string userInput;
            Console.WriteLine("Enter queue, each value in new line, put empty line to end.");
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

            TaskQueue.TaskQueue.GetMaxValue(queue);
            TaskQueue.TaskQueue.DeleteMaxValue(queue);
        }

        static void TasksForStack()
        {
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

        static void TasksForDictionary()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("Marija", 35);
            dictionary["Masha"] = 12;

            Console.WriteLine($"First element in dictionary is {dictionary.ElementAt(0).Key} and age is {dictionary["Marija"]} years");

            var firstList = new List<int>() { 6, 9, 7, 3, 4, 22, 8, 1, 2, 0 };
            var secondList = new List<string>() { "Life2", "Life1", "Life2", "Life6", "Life4", "Life5", "Life8", "Life7", "Life9", "Life8", };

            TaskDictionary.SortAndMerge(firstList, secondList);

            var cities = new Dictionary<string, KeyValuePair<string, City>>();
            cities.Add("Vilnius", new KeyValuePair<string, City>("Vilnius", new City(5642, 561616)));
            cities.Add("Klaipeda", new KeyValuePair<string, City>("Klaipeda", new City(3242, 324161)));
            cities.Add("Siauliai", new KeyValuePair<string, City>("Siauliai", new City(2142, 236521)));
            cities.Add("Kaunas", new KeyValuePair<string, City>("Kaunas", new City(4123, 452631)));
            cities.Add("Trakai", new KeyValuePair<string, City>("Trakai", new City(1025, 41202)));

            TaskDictionary.SortCities(cities);
            TaskDictionary.BrowseByPopulationReverse(cities);
            TaskDictionary.CountTotalPopulation(cities);
        }

    }
}