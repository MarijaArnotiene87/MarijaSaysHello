using System.Text.Json;

namespace Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var majaHistoryBook = new Book("Majos istorija", 650);
            var perlSisterBook = new Book("Tiges istorija", 620);
            var marijaLibrary = new Library("Marija home library", 3, false, new DateTime(2020, 05, 12), new List<Book>() { majaHistoryBook, perlSisterBook });

            var alesHistoryBook = new Book("Ales istorija", 610);
            var kelesSisterBook = new Book("Keles istorija", 590);
            var publicLibrary = new Library("Kudirkos library", 1235, true, new DateTime(1995, 03, 24), new List<Book>() { alesHistoryBook, kelesSisterBook });

            string json = JsonSerializer.Serialize(new List<Library>() { marijaLibrary, publicLibrary });

            using (FileStream fs = new FileStream("C:\\Users\\marija.arnotiene\\source\\repos\\MarijaSaysHello\\Homework12\\json\\libraries.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize<List<Library>>(fs, new List<Library>() { marijaLibrary, publicLibrary });
                Console.WriteLine("Data has been saved to file");
            }

            using (FileStream fs = new FileStream("C:\\Users\\marija.arnotiene\\source\\repos\\MarijaSaysHello\\Homework12\\json\\book.json", FileMode.OpenOrCreate))
            {
                var book = JsonSerializer.Deserialize<Book>(fs);
            }
        }
    }
}