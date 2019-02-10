using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IProduct
    {
        Product GetProduct(string productName);
        double CalculateTotal();
    }
}