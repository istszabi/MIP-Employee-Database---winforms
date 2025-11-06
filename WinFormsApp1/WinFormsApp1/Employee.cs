using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIP1;

namespace MIP1
{
    internal class Employee : Person
    {
        public string company { get; set; }
        public string position { get; set; }
        public int years { get; set; }
        public int salary { get; set; }
        public Employee(string firstName, string lastName, int age, string email,string company, string position, int years, int salary) : base(firstName, lastName, age, email)
        {
            this.company = company;
            this.position = position;
            this.years = years;
            this.salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCompany: {company}, Position: {position}, Years: {years}";
        }
    }
}
