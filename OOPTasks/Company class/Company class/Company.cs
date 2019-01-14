using System;
using System.Collections.Generic;
using System.Text;

namespace Company_class
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public int income;
        public int expense;

        public Company(string title, string address, string phone, int income, int expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.income = income;
            this.expense = expense;
        }
        public void CompanyInfo()
        {
            Console.WriteLine($"Yhtiön nimi: {this.title}");
            Console.WriteLine($"Yhtiön osoite: {this.address}");
            Console.WriteLine($"Yhtiön puhelinnumero: {this.phone}");
            Console.WriteLine($"Yhtiön tulot: {this.income}€");
            Console.WriteLine($"Yhtiön menot: {this.expense}€\n");
        }

        public Company()
        {
            this.title = "Pertin antiikki Oy";
            this.address = "Vanhatie 10, 54100 Lappeenranta";
            this.phone = "050987654";
            this.income = 100000;
            this.expense = 30000;
        }

        public Company(Company previousCompany)
        {
            this.title = previousCompany.title;
            this.address = previousCompany.address;
            this.phone = previousCompany.phone;
            this.income = previousCompany.income;
            this.expense = previousCompany.expense;
        }

        public void Profit()
        {
            double profit = 100 * (this.income - this.expense) / this.expense;
            Console.WriteLine($"Yhtiön {this.title}:n tekemä voitto on {profit}%.");

            if (profit > 300)
            {
                Console.WriteLine($"Yhtiön taloudellinen tilanne on hyvä.\n");
            }
            else if(profit < 100)
            {
                Console.WriteLine($"Yhtiön taloudellinen tilanne on huono.\n");
            }
            else
            {
                Console.WriteLine($"Yhtiön taloudellinen tilanne on kohtalainen.\n");
            }
        }
    }
}
