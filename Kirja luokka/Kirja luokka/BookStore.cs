using System;
using System.Collections.Generic;
using System.Text;

namespace Kirja_luokka
{
    class BookStore
    {
        public string title;
        public string author;
        public int IDnumber;
        public double price;
        public double bookPrice;
        public string bookTitle;

        public BookStore()
        {
            bookTitle = "Puhdistus";
            bookPrice = 19.95;
        }

        public BookStore(string title, string author, int IDnumber, double price)
        {

            this.title = title;
            this.author = author;
            this.IDnumber = IDnumber;
            this.price = price;
        }
        public void BookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {title}"); 
            Console.WriteLine($"Kirjoittaja: {author}");
            Console.WriteLine($"Kirjan ID-numero: {IDnumber}");
            Console.WriteLine($"Hinta: {price} € \n");
        }

        public string CompareBooks(BookStore book)
        {

            if (price > bookPrice)
            {
                return ($"Kirja {title} on kalliimpi kuin {bookTitle}.");
            }
            else
            {
                return ($"Kirja {bookTitle} on kalliimpi kuin {title}.");
            }
        }
    }
}
