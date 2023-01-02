using MyShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Company
    {
        //In the main project also create a class with fields, methods. One of the fields must have a class type from the included library.
        //Use multiple constructors - with different number and type of parameters. In the Main method, create several objects of the main
        //project class using various constructors and initializers. Use object methods to write some information to the console.

        public string name;
        public int foundationYear;
        public Shop store;

        public Company()
        {

        }

        public string GetCompanyInfo()
        {
            return $"Company {name} was established in {foundationYear}";
        }

        public void PrintCompanyName()
        {
            Console.WriteLine($"Company name is {name}");
        }
    }
}
