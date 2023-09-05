using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class EmployeesTrainees : Employee
    {
        public int WorkingHours { get; set; }

        public int SchoolHours { get; set; }

        public EmployeesTrainees() { }

        public EmployeesTrainees(int workingHours,int schoolHours, string name, string firstName, int salary) : base(name,firstName,salary) 
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn() 
        {
            Console.WriteLine($"{FirstName} {Name} is learning {SchoolHours} hours.");
        }

        public override void Work()
        {
            Console.WriteLine($"{FirstName} {Name} is working for {WorkingHours} hours.");
        }

    }
}
