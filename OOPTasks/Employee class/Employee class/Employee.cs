using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_class
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public double salary;

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Työntekijän nimi: {this.name}\nTyöntekijän HeTu: {this.id}\nTyöntekijän tehtävä: {this.position}\nTyöntekijän palkka: {this.salary}€/kk\n";
        }

        public string CompareSalary(Employee employee)
        {

            if (salary > employee.salary)
            {
                return ($"Työntekijän {this.name} palkka {this.salary}€/kk on suurempi, kuin työntekijän {employee.name} palkka {employee.salary}€/kk.");
            }
            else if (salary < employee.salary)
            {
                return ($"Työntekijän {employee.name} palkka {employee.salary}€/kk on suurempi, kuin työntekijän {this.name} palkka {this.salary}€/kk.");
            }
            else if (salary < employee.salary)
            {
                return ($"Työntekijän {this.name} palkka {this.salary}€/kk on suurempi, kuin työntekijän {employee.name} palkka {employee.salary}€/kk.");
            }
            else
                return ($"Työntekijän {this.name} palkka {this.salary}€/kk on yhtäsuuri, kuin työntekijän {employee.name} palkka {employee.salary}€/kk.");
        }
    }
}