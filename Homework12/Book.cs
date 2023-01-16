namespace Homework12
{
    public class Book
    {
        public string Name { get; set; }
        public int PagesCount { get; set; }

        public Book(string name, int pagesCount)
        {
            Name = name;
            PagesCount = pagesCount;
        }
    }
}