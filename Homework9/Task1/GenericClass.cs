namespace Homework9.Task1
{
    public class GenericClass<T> where T : Human
    {
        public T[] array = { };

        public void AddElementToArray(T element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = element;
        }

        public void RemoveLastElementFromArray()
        {
            if (array.Length != 0)
                Array.Resize(ref array, array.Length - 1);
        }

        public T GetElementFromArray(int index) => array[index];

        public int GetArrayLength() => array.Length;

        public void ToString()
        {
            foreach (var element in array)
            {
                Console.WriteLine(element.name);
            }
            if (typeof(T) == typeof(Man))
            {
                Console.WriteLine("There’re only men");
            }
            else
            {
                Console.WriteLine("There’re only women");
            }
        }
    }
}
