using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Employee
    {
        public string Name { get; set; }

        public string FirstName { get; set; }

        public int Salary { get; set; }

        public Employee()
        {

        }

        public Employee (string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{FirstName} {Name} is working");
        }
        public void Pause()
        {
            Console.WriteLine($"{FirstName} {Name} is taking a break.");
        }
   
    }
}
