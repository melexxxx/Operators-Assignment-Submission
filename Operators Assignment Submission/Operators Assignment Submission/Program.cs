using System;

namespace EmployeeComparison // Make sure this matches the Employee class namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };
            Employee emp3 = new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" };

            Console.WriteLine(emp1 == emp2); // Output: True
            Console.WriteLine(emp1 == emp3); // Output: False
            Console.WriteLine(emp1 != emp2); // Output: False
            Console.WriteLine(emp1 != emp3); // Output: True

            Console.ReadLine();
        }
    }
}
