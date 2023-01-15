namespace Homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        public static void Task1()
        {
            var numbers = new List<int>() { 0, 2, 4, 5, 6, 8 };

            var selectedNumbers = from p in numbers
                                  where p % 2 == 0
                                  select p;

            Console.Write("The numbers which produce the remainder 0 after divided by 2 are:");
            foreach (var number in selectedNumbers)
                Console.Write($" {number}");
            Console.WriteLine();
        }

        public static void Task2()
        {
            var numbers = new List<int>() { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var positive = from i in numbers
                           where i > 0
                           where i >= 1 && i <= 11
                           select i;

            foreach (var number in positive)
                Console.Write($" {number}");
            Console.WriteLine();
        }

        public static void Task3()
        {
            int[] numbers = { 9, 8, 6, 5 };

            var squares = from i in numbers
                          select new
                          {
                              Number = i,
                              SqrNo = i * i
                          };


            foreach (var item in squares)
                Console.WriteLine($"{{ Number = {item.Number}, SqrNo = {item.SqrNo} }}");
        }

        public static void Task4()
        {
            int[] numbers = { 1, 5, 9, 5, 9, 5 };

            var groupedNumbers = (from n in numbers
                                  group n by n into g
                                  select new { Number = g.Key, Count = g.Count() })
                                  .OrderByDescending(n => n.Count);

            Console.WriteLine("The number and the Frequency are :");
            foreach (var item in groupedNumbers)
                Console.WriteLine($"Number {item.Number} appears {item.Count} times");
        }
    }
}