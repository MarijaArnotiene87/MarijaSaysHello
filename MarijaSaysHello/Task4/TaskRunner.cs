namespace Marija_SaysHello.Task4
{
    public class TaskRunner
    {
        public static void Task4Runner()
        {
            //Exercise1();
            Exercise2();
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

            while (i <= 9)
            {
                Console.WriteLine($"{i} x {x} = {i * x}");
                i++;
            }
        }

    }
}
