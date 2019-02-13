using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Product : IProduct
    {
        public string productName;
        public double productPrice;
        public double productAmount;

        public Product()
        {
            productName = string.Empty;
            productPrice = 0;
            productAmount = 0;
        }

        public Product(string _productName, double productPrice, double productAmount)
        {
            this.productName = _productName;
            this.productPrice = productPrice;
            this.productAmount = productAmount;
        }

        public override string ToString()
        {
            return ($"Tuotteen nimi: {productName}" +
                    $"\nTuotteen hinta: {productPrice}€" +
                    $"\nTuotteiden lukumäärä: {productAmount}");
        }

        public string GetProduct(string productName)
        {
            if (this.productName.Equals(productName))
            {
                return ToString();
            }
            else
            {
                return null;
            }
        }

        public string CalculateTotal()
        {
            double totalValue = productPrice * productAmount;
            return ($"Yhteishinta: {totalValue}€\n");
        }

        object IProduct.GetProduct(string productName)
        {
            throw new NotImplementedException();
        }

        double IProduct.CalculateTotal()
        {
            throw new NotImplementedException();
        }
    }
}