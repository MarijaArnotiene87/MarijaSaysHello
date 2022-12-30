namespace Marija_SaysHello.Task4
{
    public class TaskRunner
    {
        public static void Task4Runner()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            Exercise4();
        }

        public static void Exercise1()
        {
            Console.Write("Hi! Please enter the positive number:  ");

            var userInput = Console.ReadLine();

            int userInputValue;
            var isParsable = int.TryParse(userInput, out userInputValue);
            if (!isParsable)
            {
                Console.WriteLine("Could not be parsed.");

                return;
            }

            int sumOfnumbers = 0;
            for (int i = 0; i <= userInputValue; i++)
            {
                sumOfnumbers = sumOfnumbers + i;
            }
            Console.WriteLine($"{sumOfnumbers}");
        }

        public static void Exercise2()
        {
            const int x = 3;
            int i = 1;
            int numberOfOperation = 9;

            while (i <= numberOfOperation)
            {
                Console.WriteLine($"{i} x {x} = {i * x}");
                i++;
            }
        }

        public static void Exercise3()
        {
            int[] numbers = new[] { 3, 5, 9, 8, 15 };

            int result = numbers[0];
            for (int i = 1; i != numbers.Length; i++)
            {
                result = result * numbers[i];
            }
            Console.WriteLine($"{result}");
        }

        public static void Exercise4()
        {
            int number = 2048;
            int dividerValue = 2;
            int counter = 0;
            int minimumNumber = 10;

            while (number > minimumNumber)
            {
                number = number / dividerValue;
                counter++;
            }
            Console.WriteLine($"Number of division operation: {counter}");
        }

    }
}

