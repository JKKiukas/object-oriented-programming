using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa tietoja tuotteista, asiakkaista ja urheiluliikkeestä.\n");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> productList = new List<Product>();
            Product firstProduct = new Product("Sukset", 120.00, 2);
            Product secondProduct = new Product("Monot", 60.00, 2);
            Product thirdProduct = new Product("Sauvat", 30.00, 2);

            Console.WriteLine(firstProduct.ToString());
            Console.WriteLine(firstProduct.CalculateTotal());

            Console.WriteLine(secondProduct.ToString());
            Console.WriteLine(secondProduct.CalculateTotal());

            Console.WriteLine(thirdProduct.ToString());
            Console.WriteLine(thirdProduct.CalculateTotal());
            Console.WriteLine(new string('-', 25));

            List<Customer> customerList = new List<Customer>();
            Customer firstCustomer = new Customer("Jouko", 500.00);
            Customer secondCustomer = new Customer("Pertti", 1500.00);
            Customer thirdCustomer = new Customer("Matti", 2500.00);

            Console.WriteLine(firstCustomer.ToString());
            Console.WriteLine($"Asiakkaan bonus: {firstCustomer.CalculateBonus()}€\n");

            Console.WriteLine(secondCustomer.ToString());
            Console.WriteLine($"Asiakkaan bonus: {secondCustomer.CalculateBonus()}€\n");

            Console.WriteLine(thirdCustomer.ToString());
            Console.WriteLine($"Asiakkaan bonus: {thirdCustomer.CalculateBonus()}€\n");
            Console.WriteLine(new string('-', 33));

            Store store = new Store("Kallen urheiluliike", 0);

            store.AddProduct(new Product("Sukset", 120.00, 100));
            store.AddProduct(new Product("Monot", 60.00, 100));
            store.AddProduct(new Product("Sauvat", 30.00, 100));

            store.AddCustomer(new Customer("Jouko", 500.00));
            store.AddCustomer(new Customer("Pertti", 1500.00));
            store.AddCustomer(new Customer("Matti", 2500.00));

            Console.WriteLine(store.ToString());
            store.PrintProducts();
            Console.WriteLine(new string('-', 25));
            store.PrintCustomers();
        }
    }
}