namespace Homework12
{
    public class Library
    {
        public string Name { get; set; }
        public int ShelvesCount { get; set; }
        public bool IsPublic { get; set; }
        public DateTime EstablishedDate { get; set; }
        public List<Book> Books { get; set; }

        public Library(string name, int shelvesCount, bool isPublic, DateTime establishedDate, List<Book> books)
        {
            Name = name;
            ShelvesCount = shelvesCount;
            IsPublic = isPublic;
            EstablishedDate = establishedDate;
            Books = books;
        }
    }
}
