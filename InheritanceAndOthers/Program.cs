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

            int howMany = employees?.Count ?? 0;

            int ?test = employees?.Count;

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }

            List<int> listofInt = new List<int> {
                1,
                5,
                8,
                10,
                15,
                5,
                7,
                6,
                7
            };

            // or var smallerNumbers (less boilerplate)
            IEnumerable<int> smallerNumbers = from num in listofInt
                                 where num < 8
                                 select num;

            foreach( int number in smallerNumbers) {
                Console.WriteLine($"small: {number}");
            }

            Console.WriteLine("\n--------------\n");

            var smallerNumbers2 = listofInt
                .Where(n => n < 8)
                .Select(n => n);

            foreach (int number in smallerNumbers)
            {
                Console.WriteLine($"small2: {number}");
            }

            Console.WriteLine("\n--------------\n");

            var methods = from method in typeof(int).GetMethods()
                          orderby method.Name
                          group method by method.Name into groups
                          select new
                          {
                              MethodName = groups.Key,
                              MethodOverloads = groups.Count()
                          };
            foreach (var method in methods)
            {
                Console.WriteLine($"{method.MethodName} - {method.MethodOverloads}");
            }

            Console.WriteLine("\n--------------\n");

            Console.WriteLine(listofInt.Any(x => x == 7));

            Console.WriteLine("\n--------------\n");

            var outputDistinct = listofInt.Distinct()
                .Select(x => x * 9);

            foreach (var element in outputDistinct)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\n--------------\n");

            List<string> codes = new List<String> {"BE", "NL"};
            List<string> countries = new List<String> { "BELGIE", "NEDERLANDS" };

            var codesWithCountries =
                codes.Zip(countries, (code, country) =>
                    $"{code} : {country}");

            foreach (var zipped in codesWithCountries)
            {
                Console.WriteLine(zipped);
            }
        }
    }
}
