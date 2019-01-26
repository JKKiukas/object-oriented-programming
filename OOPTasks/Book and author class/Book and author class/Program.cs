using System;
using Literature;

namespace Book_and_author_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa tietoja kirjoista ja niiden kirjoittajista.\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book firstBook = new Book("Pyörre", "Ilkka Remes", "WSOY", 39.95, "Jännitys");
            firstBook.GetBook("Pyörre");
            firstBook.Price = 39.95;
            Console.WriteLine($"Uusi hinta: {firstBook.Price:F2}€");
            Book.ChangeGenre("Uusi teema: Trilleri");
            Console.WriteLine(Book.genreName);
            Console.WriteLine("------------------------------------\n");

            Author firstAuthor = new Author("Ilkka Remes", "13.12.1962", firstBook);
            firstAuthor.PrintAuthorInfo();

            Book secondBook = new Book("Puhdistus", "Sofi Oksanen", "WSOY", 49.95, "Jännitys");
            secondBook.GetBook("Puhdistus");
            secondBook.Price = 49.95;
            Console.WriteLine($"Uusi hinta: {secondBook.Price:F2}€");
            Book.ChangeGenre("Uusi teema: Trilleri");
            Console.WriteLine(Book.genreName);
            Console.WriteLine("------------------------------------\n");

            Author secondAuthor = new Author("Sofi Oksanen", "7.1.1977", secondBook);
            secondAuthor.PrintAuthorInfo();
        }
    }
}
