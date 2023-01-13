using Homework10.LinkedList;
using Homework10.List;
using System.Collections.Generic;
using System.Xml.Linq;

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
        }
    }
}