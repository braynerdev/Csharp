using ExercicioFuncionario.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee("Alex", 50, 20.0);
            employees.Add(employee1);
            Employee employee3 = new Outsource("Bob", 100, 15.0, 200.0);
            employees.Add(employee3);
            Employee employee4 = new Employee("Maria", 60, 20.0);
            employees.Add(employee4);

            foreach (Employee employee in employees)
            {
                Console.WriteLine("PAYMENTS:");
                Console.WriteLine($"{employee.Name} - $ " +
                    $"{employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}