using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface ICustomer
    {
        object GetCustomer(string customerName);
        double GetBonus();
    }
}