using Bangazon_inc.Stuff;
using System;
using System.Collections.Generic;

namespace Bangazon_inc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }
            // Create a property for holding a list of current employees
            List<Employee> employees = new List<Employee>();

            // Create a method that allows external code to add an employee
            public void AddEmployee(Employee newEmployee)
            {
                employees.Add(newEmployee);
            }

            // Create a method that allows external code to remove an employee
            public void RemoveEmployee(Employee firedEmployee)
            {
                employees.Remove(firedEmployee);
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
        }
    }
}
