﻿namespace Marija_SaysHello.Task3
{
    public class TaskRunner
    {
        public static void Task3Runner()
        {
            Number1();
            Number2();
            Number3();
        }

        public static void Number1()
        {
            var num = 20;
            num += 5;

            Console.WriteLine($"Variable: var {num}");
        }

        public static void Number2()
        {
            //uznat na schiot mesiacev i dnej v godu
            Console.Write("Hi! Please enter the four-digit number:  ");

            string userInput = Console.ReadLine();
            int n;

            bool isParsable = Int32.TryParse(userInput, out n);
            if (!isParsable)
            {
                Console.WriteLine("Could not be parsed.");
                return;
            }

            int daysInYear = 365;

            int years = n / daysInYear;

            int daysInMonth = 30;
            int months = (n - years * daysInYear) / daysInMonth;


            int days = n - years * daysInYear - months * daysInMonth;

            Console.WriteLine($"{years} years, {months} months, {days} days");
        }

        public static void Number3()
        {

        }
    }
}
