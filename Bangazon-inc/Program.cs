using Bangazon_inc.Stuff;
using System;
using System.Collections.Generic;

namespace Bangazon_inc
{
    class Program
    {
        static void Main(string[] args)
        {
            var drumWorks = new Company("Drum Works", new DateTime());
            var vinnieCalaiuta = new Employee("Vinnie Calaiuta", "Chief Drumming Officer", new DateTime());
            var jackDejohnette = new Employee("Jack DeJohnette", "VP Jazz", new DateTime());
            var johnBonham = new Employee("John Bonham", "CEO", new DateTime());

            drumWorks.AddEmployee(vinnieCalaiuta);
            drumWorks.AddEmployee(jackDejohnette);
            drumWorks.AddEmployee(johnBonham);

            drumWorks.ListEmployees();

            Console.ReadLine();
        }

        public class Company
        {
            /*
                Some readonly properties
            */
            public string Name { get; }
            public DateTime CreatedOn { get; }

            // Create a property for holding a list of current employees
            List<Employee> CurrentPeeps { get; } = new List<Employee>();

            // Create a method that allows external code to add an employee
            public void AddEmployee(Employee newEmployee)
            {
                CurrentPeeps.Add(newEmployee);
            }

            // Create a method that allows external code to remove an employee
            public void RemoveEmployee(Employee firedEmployee)
            {
                CurrentPeeps.Remove(firedEmployee);
            }

            public void ListEmployees()
            {
                foreach (var employee in CurrentPeeps)
                {
                    Console.WriteLine(employee.EmployeeName);
                }
            }
            /*
                Create a constructor method that accepts two arguments:
                    1. The name of the company
                    2. The date it was created

                The constructor will set the value of the public properties
            */
            public Company(string name, DateTime createdOn)
            {
                Name = name;
                CreatedOn = createdOn;
            }


        }
    }
}
