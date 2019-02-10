using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Customer : ICustomer
    {
        public string customerName;
        public double customerShopping;

        public Customer()
        {
            customerName = string.Empty;
            customerShopping = 0;
        }

        public Customer(string customerName, double customerShopping)
        {
            this.customerName = customerName;
            this.customerShopping = customerShopping;
        }

        public override string ToString()
        {
            return ($"Asiakkaan nimi: {customerName}" +
                    $"\nAsiakkaan ostokset: {customerShopping}€");
        }

        public string GetCustomer(string customerName)
        {
            if(this.customerName.Equals(customerName))
            {
                return ToString();
            }
            else
            {
                return null;
            }
        }

        public double CalculateBonus()
        {
            if (customerShopping <= 1000)
            {
                double bonus = customerShopping * 0.02;
                return bonus;
            }
            else if(customerShopping <= 2000)
            {
                double bonus = customerShopping * 0.03;
                return bonus;
            }
            else
            {
                double bonus = customerShopping * 0.05;
                return bonus;
            }
        }

        void ICustomer.GetCustomer(string customerName)
        {
            throw new NotImplementedException();
        }

        void ICustomer.GetBonus()
        {
            throw new NotImplementedException();
        }
    }
}