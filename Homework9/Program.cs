using Homework9.Task1;

namespace Homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<Woman> genericWoman = new GenericClass<Woman>();

            Woman woman1 = new Woman();
            genericWoman.AddElementToArray(woman1);

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