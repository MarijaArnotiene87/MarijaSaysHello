using Homework9.Task1;
using System.Linq.Expressions;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<Woman> genericWoman = new GenericClass<Woman>();

            Woman woman1 = new Woman();
            genericWoman.AddElementToArray(woman1);

            GenericClass<Man> genericMan = new GenericClass<Man>();

            Man man= new Man();
            genericMan.AddElementToArray(man);

            genericMan.ToString();
            genericWoman.ToString();

            //В классе с методом Main напишите обобщённый метод, который будет генерировать заданное количество элементов,
            //элементы могут быть только типа Man и Woman и должны создаваться через вызов конструктора их класса new()

        }

        void GenerateElements(int count)
        {
            for (int i = 0; i < count; i++)
            {

            }
        }
    }
}