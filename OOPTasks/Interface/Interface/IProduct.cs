using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IProduct
    {
        object GetProduct(string productName);
        double CalculateTotal();
    }
}