using System;

namespace Company_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo tietoja käyttäjälle eri yhtiöstä ja niiden taloudellisesta tilanteesta.\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Company firstCompany = new Company("Joukon autokorjaamo Oy", "Ruuvikuja 2, 53100 Lappeenranta", "040123456", 25000, 20000);
            Company secondCompany = new Company();
            //Adds copy constructor. Copies first company's info.
            Company thirdCompany = new Company(firstCompany);           

            firstCompany.CompanyInfo();
            secondCompany.CompanyInfo();
            thirdCompany.CompanyInfo();

            //Changes first company's info.
            thirdCompany.title = "Matin kultakello Oy";
            thirdCompany.address = "Arvotie 18, 53100 Lappeenranta";
            thirdCompany.phone = "040061938";
            thirdCompany.income = 350000;
            thirdCompany.expense = 75000;

            thirdCompany.CompanyInfo();

            firstCompany.Profit();
            secondCompany.Profit();
            thirdCompany.Profit();
        }
    }
}
