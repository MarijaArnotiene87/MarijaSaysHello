using System.Globalization;

namespace Marija_SaysHello.Task3
{
    public class TaskRunner
    {
        public static void Task3Runner()
        {
            //Number1();
            //Number2();
            //Number3();
            //Number4();
            Number5();
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
            //uznat nuzhno li sdelat proverku esli vvediosh ne chetiriohznachnoe chislo
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
            Console.Write("Please enter any number: ");
            string number = Console.ReadLine(); // nuzno li kak to sdelat chtoby menialas zapiataja na tochku

            float n = float.Parse(number, CultureInfo.InvariantCulture.NumberFormat);

            float value = n + n * 2;

            Console.WriteLine($"The result (n + n * 2): {value}");
        }

        public static void Number4()
        {
            sbyte bit1 = -34;
            byte bit2 = 4;
            string a = "Hello";
            char b = 'R';
            double c = 23.093433222;
            ushort d = 40000;
            bool isTrue = true;
            byte e = 0;
        }

        public static void Number5()
        {
            //short, ulong, char, double
            Console.Write("Please enter value: ");
            string inputValue = Console.ReadLine();
            short s;
            ulong u;
            char ch;
            double d;

            bool resultShort = short.TryParse(inputValue, out s);
            if (resultShort)
            {
                Console.WriteLine($"{inputValue} value is short");
                return;
            }

            bool resultUlong = ulong.TryParse(inputValue, out u);
            if (resultUlong)
            {
                Console.WriteLine($"{inputValue} value is ulong");
                return;
            }

            bool resultChar = char.TryParse(inputValue, out ch);
            if (resultChar)
            {
                Console.WriteLine($"{inputValue} value is char");
                return;
            }

            bool resultDouble = double.TryParse(inputValue, out d);
            if (resultDouble)
            {
                Console.WriteLine($"{inputValue} value is double");
                return;
            }

            Console.WriteLine($"{inputValue} is not short, ulong, char or double");
        }
    }
}
