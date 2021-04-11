using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;

            Console.WriteLine(square(3));
            Console.WriteLine(add(21,5));

            IEnumerable<Employee> developers = new Employee[]
           {
                new Employee {Id = 1, Name = "Filip" }, 
                new Employee {Id = 2, Name = "Dawid"},
                new Employee {Id = 2, Name = "Steven"}

           };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Konrad"}
            };


            foreach (var employee in developers.Where(NameStarsWithS))
            {
                Console.WriteLine(employee.Name);
            }

            foreach (var employee in developers.Where(e => e.Name.StartsWith("S")))
            {
                Console.WriteLine(employee.Name);
            }

            foreach (var employee in developers.Where(  
                delegate (Employee employee)
                {
                return employee.Name.StartsWith("S");
                }))
            {
                Console.WriteLine(employee.Name);
            }

        }

        private static bool NameStarsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
