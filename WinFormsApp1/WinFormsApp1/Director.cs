using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIP1
{
    internal class Director : Person
    {

        private static Director? instance;
        public string company { get; set; }
        public string position { get; set; }
        public int years { get; set; }
        public int salary { get; set; }
        public int bonus { get; set; }

        public int managerCounter = Manager.getManagerCount();
        private Director(string firstName, string lastName, int age, string email, string company, string position, int years, double salary, int bonus) : base(firstName, lastName, age, email)
        {
            this.company = company;
            this.position = position;
            this.years = years;
            this.bonus = bonus;
            this.managerCounter = managerCounter;
            this.salary = (int)(salary +(0.2 * salary + managerCounter));
        }

        public static Director GetInstance(string firstName, string lastName, int age, string email, string company, string position, int years, double salary, int bonus)
        {
            if (instance == null)
            {
                instance = new Director(firstName, lastName, age, email, company, position, years, salary, bonus);
            }
            return instance;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCompany: {company}, Position: {position}, Years: {years}, Salary: {salary}, Bonus: {bonus}, Nr. of Managers Directed: {managerCounter}";
        }
    }
}
