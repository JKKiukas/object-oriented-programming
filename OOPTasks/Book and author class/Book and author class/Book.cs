using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
{
    class Book
    {
        public string title;
        public readonly string _author;
        public string publisher;
        private double _price;
        public static string genreName;

        public Book(string title_, string author, string publisher, double price, string genre)
        {
            title = title_;
            _author = author;
            this.publisher = publisher;
            _price = price;
            genreName = genre;
        }

        public void GetBook(string title_)
        {
            if (title.Equals(title_))
            {
                Console.WriteLine($"Kirjan nimi: {title}");
                Console.WriteLine($"Kirjoittaja: {_author}");
                Console.WriteLine($"Kustantaja: {publisher}");
                Console.WriteLine($"Hinta: {Price}€");
                Console.WriteLine($"Teema: {genreName}");
            }
            else
            {
                Console.WriteLine($"Kirjaa {title_} ei löytynyt.");
            }
        }

        public static void ChangeGenre(string genre)
        {
            genreName = genre;
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value > 30.00)
                {
                    _price = value * 0.9;
                }
                else
                {
                    _price = value;
                }
            }
        }

        public string AuthorValue
        {
            get
            {
                return _author;
            }
        }
    }
}