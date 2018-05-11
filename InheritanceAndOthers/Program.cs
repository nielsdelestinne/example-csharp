using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee bob = new Worker("Bob", 35.00);
            Employee joe = new Manager("Joe", true);


            List<Employee> employees = new List<Employee>()
            {
                joe,
                bob
            };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
