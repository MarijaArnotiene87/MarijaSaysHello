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

            Man man = new Man();
            genericMan.AddElementToArray(man);

            genericMan.ToString();
            genericWoman.ToString();

            GenerateElements<Man>(2);
            GenerateElements<Woman>(3);

            genericMan.GetElementFromArray(0);
            genericMan.GetArrayLength();
            genericMan.RemoveLastElementFromArray();
        }

        static void GenerateElements<T>(int elementCount) where T : Human, new()
        {
            for (int i = 0; i < elementCount; i++)
            {
                new T();
            }
        }

    }
}