namespace Marija_SaysHello.Task4
{
    public class TaskRunner
    {
        public static void Task4Runner()
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            //Exercise7();
            Exercise8();
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

        public static void Exercise5()
        {
            string[] wordList = new[] { "Hi", "Welcome", "Goodbye", "Hello", "How are you?" };

            foreach (string word in wordList)
            {
                if (word == "Hello")
                {
                    Console.WriteLine("Labas!");
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static void Exercise6()
        {
            int[] numbers = new int[] { 8, 9, 52, 32, 47, 15 };

            Console.WriteLine($"Sum of first element {numbers[0]} and last element {numbers[numbers.Length - 1]} equals {numbers[0] + numbers[numbers.Length - 1]}");
        }

        public static void Exercise7()
        {
            int[] numbers = new int[] { 8, 5, 9, 52, 32, 47, 15 };

            int minValue = numbers[0];
            int maxValue = numbers[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                    minIndex = i;
                }

                if (maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Sum of min index {minIndex} and max index {maxIndex} equals {minIndex + maxIndex}");
        }

        public static void Exercise8()
        {
            int[] numbers = new int[] { 8, 5, 9, 52, 32, 47, 15 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int value;
                        value = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = value;
                    }
                }
            }
            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }
        }

    }
}

