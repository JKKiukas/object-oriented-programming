using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket_price_class
{
    class Customer
    {
        public bool MtkMember;
        public bool Serviceman;
        public bool Student;
        public bool MtkMemberAndStudent;
        public double Discount;
        public double TicketPrice;

        public Customer()
        {
        }

        public Customer(bool MtkMember, bool Serviceman, bool Student, bool MtkMemberAndStudent, double Discount, double TicketPrice)
        {
            this.MtkMember = MtkMember;
            this.Serviceman = Serviceman;
            this.Student = Student;
            this.MtkMemberAndStudent = MtkMemberAndStudent;
            this.Discount = Discount;
            this.TicketPrice = TicketPrice;
        }

        public void AskCustomerInfo()
        {
            Console.WriteLine("Mihin ryhmään kuulut.\n");
            Console.WriteLine("1. Mtk jäsen");
            Console.WriteLine("2. Varusmies");
            Console.WriteLine("3. Opiskelija");
            Console.WriteLine("4. Opiskelija sekä Mtk jäsen.\n");

            Console.WriteLine("Jos et kuulu mihinkään ylläolevaan ryhmään, valitse ikäryhmäsi.\n");

            Console.WriteLine("5. 0-6 vuotiaat.");
            Console.WriteLine("6. 7-15 vuotiaat.");
            Console.WriteLine("7. 16-64 vuotiaat.");
            Console.WriteLine("8. Yli 64 vuotiaat.\n");

            double TicketPrice = 16.00;
            Console.Write("Syötä valintasi: ");
            string userInput = Console.ReadLine();
            int userChoice = int.Parse(userInput);

            if (userChoice == 1)
            {
                Discount = 0.15;
            }
            else if (userChoice == 2)
            {
                Discount = 0.5;
            }
            else if (userChoice == 3)
            {
                Discount = 0.45;
            }
            else if (userChoice == 4)
            {
                Discount = 0.6;
            }
            else if (userChoice == 5)
            {
                Discount = 1;
            }
            else if (userChoice == 6)
            {
                Discount = 0.5;
            }
            else if (userChoice == 7)
            {
                Discount = 0;
            }
            else if(userChoice == 8)
            {
                Discount = 0.5;
            }

            Console.WriteLine($"\nLipun hintasi on {TicketPrice - TicketPrice * Discount}€.");
        }
    }
}