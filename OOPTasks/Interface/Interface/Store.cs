using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class Store : ICustomers, IProducts
    {
        public string name;
        public double sales;
        List<Product> products = new List<Product>();
        List<Customer> customers = new List<Customer>();

        public Store(string name)
        {
            this.name = name;
        }

        public Store(double sales)
        {
            this.sales = sales;
        }

        public Store(string name, double sales, List<Product> products, List<Customer> customers)
        {
            this.name = name;
            this.sales = sales;
            this.products = products;
            this.customers = customers;
        }

        public Store(string name, int v) : this(name)
        {
        }

        public Store(double sales, int v) : this(sales)
        {
        }

        public override string ToString()
        {
            return ($"Kaupan nimi: {name}" +
                    $"\nLiikevaihto: {sales}€");
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteiden lukumäärä kaupassa: {products.Count}");
            Console.WriteLine($"Asiakkaiden lukumäärä kaupassa: {customers.Count}\n");
            Console.WriteLine(new string('-', 33));

            foreach (Product product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine(product.CalculateTotal());
            }
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void PrintCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine($"Bonusta kertynyt: {customer.CalculateBonus()}€\n");
            }
        }

        void ICustomers.AddCustomers(Customer customer)
        {
            throw new NotImplementedException();
        }

        void ICustomers.PrintProduct()
        {
            throw new NotImplementedException();
        }
    }
}