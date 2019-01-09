using System;

namespace Kirja_luokka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            BookStore firstBook = new BookStore("Pyörre", "Ilkka Remes", 111000111, 29.95);
            firstBook.BookInfo();

            BookStore secondBook = new BookStore("Puhdistus", "Sofi Oksanen", 222000222, 19.95);
            secondBook.BookInfo();

            Console.WriteLine(firstBook.CompareBooks(secondBook));
        }
    }
}
