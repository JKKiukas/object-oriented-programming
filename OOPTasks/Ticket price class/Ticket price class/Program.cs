using System;

namespace Ticket_price_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää millaisen alennuksen käyttäjä saa maatalousnäyttelyyn.\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Customer newCustomer = new Customer();

            newCustomer.AskCustomerInfo();
        }
    }
}
