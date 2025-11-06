using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIP1
{
    internal class Manager : Person
    {
        public string company { get; set; }
        public string position { get; set; }
        public int years { get; set; }
        public int salary {  get; set; }
        public int bonus { get; set; }

        private static int managerCounter = 0;
        public Manager(string firstName, string lastName, int age, string email, string company, string position, int years, int salary, int bonus) : base(firstName, lastName, age, email)
        {
            this.company = company;
            this.position = position;
            this.years = years;
            this.salary = salary;
            this.bonus = bonus;
            managerCounter++;
        }

        public static int getManagerCount()
        {
            return managerCounter;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCompany: {company}, Position: {position}, Years: {years}, Salary: {salary}, Bonus: {bonus}";
        }
    }
}
