using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Person
    {
        public string Name { get; set; }
        public string SSN { get; set; }

        int yearOfBirth;
        public int YearOfBirth
        {
            get { return yearOfBirth; }
            set
            {
                if (value > 0)
                {
                    yearOfBirth = value;
                }
            }
        }

        public Person()
        {

        }

        public Person(string newName, string newSSN, int yob)
        {
            this.Name = newName;
            this.SSN = newSSN;
            this.YearOfBirth = yob;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hello, I am {Name}, I am born in {YearOfBirth}, and my SSN is {SSN}.");
        }

        public string GetInfo()
        {
            string info = $"Hello, I am {Name}, I am born in {YearOfBirth}, and my SSN is {SSN}.";
            return info;
        }
    }
}
