using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIP1
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        private static int counter = 0;
        public Person(string firstName, string lastName, int age, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
            counter++;
        }

        public static int getCounter()
        {
            return counter;
        }
        public void Introduction()
        {
            Console.WriteLine("Hi, My name is " + firstName + " " + lastName + ".");
        }
        public override string ToString()
        {
            return "Name:" + firstName + " " + lastName + ", age:" + age + ", email:" + email;
        }
    }

}
