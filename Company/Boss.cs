using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Company
{
    public class Boss : Employee
    {
        public string CompanyCar { get; set; }
        public Boss() { }

        public Boss(string companyCar,string name, string firstName, int salary) : base(name, firstName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead ()
        {
            Console.WriteLine($"{FirstName} {Name} is leading the company.");
        }
    }

    }

