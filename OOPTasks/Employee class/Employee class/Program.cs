using System;

namespace Employee_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa työntekijöiden tiedot ja vertailee palkkoja.\n");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Jouko", "271068-893L", "Autonasentaja", 2300);
            employees[1] = new Employee("Pertti", "030872-375D", "Yksityisyrittäjä", 2500);
            employees[2] = new Employee("Matti", "170474-751T", "Kelloseppä", 2800);
            employees[3] = new Employee("Kalevi", "100676-239U", "Puuseppä", 2300);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine(employees[0].CompareSalary(employees[1]));
            Console.WriteLine(employees[0].CompareSalary(employees[2]));
            Console.WriteLine(employees[2].CompareSalary(employees[1]));
            Console.WriteLine(employees[0].CompareSalary(employees[3]));
        }
    }
}
