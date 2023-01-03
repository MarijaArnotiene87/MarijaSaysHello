namespace Marija_SaysHello.Task4
{
    public class TaskRunner
    {
        public static void Task4Runner()
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();
            Exercise10();
            Exercise11();
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

            int sumOfNumbers = 0;
            for (int i = 0; i <= userInputValue; i++)
            {
                sumOfNumbers += i;
            }

            Console.WriteLine($"{sumOfNumbers}");
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
            int[] numbers = { 3, 5, 9, 8, 15 };

            int result = numbers[0];
            for (int i = 1; i != numbers.Length; i++)
            {
                result *= numbers[i];
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
                number /= dividerValue;
                counter++;
            }

            Console.WriteLine($"Number of division operation: {counter}");
        }

        public static void Exercise5()
        {
            string[] wordList = { "Hi", "Welcome", "Goodbye", "Hello", "How are you?" };

            foreach (string word in wordList)
            {
                if (word == "Hello")
                {
                    Console.WriteLine("Labas!");
                    break;
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }

        public static void Exercise6()
        {
            int[] numbers = { 8, 9, 52, 32, 47, 15 };

            Console.WriteLine($"Sum of first element {numbers[0]} and last element {numbers[numbers.Length - 1]} equals {numbers[0] + numbers[numbers.Length - 1]}");
        }

        public static void Exercise7()
        {
            int[] numbers = { 8, 5, 9, 52, 32, 47, 15 };

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
            int[] numbers = { 8, 5, 9, 52, 32, 47, 15 };

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

        public static void Exercise9()
        {
            int numberOfOperation = 10;

            for (int x = 1; x <= numberOfOperation; x++)
            {
                int i = 1;
                while (i <= numberOfOperation)
                {
                    Console.WriteLine($"{i} x {x} = {i * x}");
                    i++;
                }

                Console.WriteLine();
            }
        }

        public static void Exercise10()
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void Exercise11()
        {
            //Create an array of numbers: int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //1.Add the number 11 to the end of the array
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < newArray.Length - 1; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = 11;
            array = newArray;

            //2.Add the number -1 to the beginning of the array
            newArray = new int[array.Length + 1];
            newArray[0] = -1;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }

            array = newArray;

            //3.Add number 12 to position 4
            newArray = new int[array.Length + 1];
            int arrayIndex = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == 3)
                {
                    newArray[i] = 12;
                    arrayIndex--;
                }
                else
                {
                    newArray[i] = array[arrayIndex];
                }

                arrayIndex++;
            }

            array = newArray;

            //4.Remove the first element of the array
            newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i + 1];
            }

            array = newArray;

            //5.Creating an array from two arrays: the first array is array, the second is int[] array2 = { 100, 200, 300 }.
            //The resulting array must contain both array and array2 numbers
            int[] array2 = { 100, 200, 300 };
            int[] resultArray = new int[array.Length + array2.Length];

            for (int i = 0; i < array.Length; i++)
            {
                resultArray[i] = array[i];
            }

            for (int i = 0; i < array2.Length; i++)
            {
                resultArray[i + array.Length] = array2[i];
            }
        }

    }
}

