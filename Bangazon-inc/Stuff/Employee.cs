using System;
using System.Collections.Generic;
using System.Text;

namespace Bangazon_inc.Stuff
{
    class Employee
    {
        public string EmployeeName { get; } 

        public string JobTitle { get; } 

        public DateTime StartDate {get; } 

        public Employee(string employeeName, string jobTitle, DateTime startDate)
        {
            EmployeeName = employeeName;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
    
}
