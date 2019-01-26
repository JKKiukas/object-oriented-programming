using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace Book_and_author_class
{
    class Author
    {
        public string name;
        public string birthday;
        readonly Book Book;

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            Book = book;
        }

        public void PrintAuthorInfo()
        {
            Console.WriteLine($"Kirjan nimi: {this.Book.title}");
            Console.WriteLine($"Kirjailijan nimi: {this.name}");
            Console.WriteLine($"Kirjailijan syntymäpäivä: {this.birthday}\n");
            Console.WriteLine("------------------------------------\n");
        }
    }
}
