using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class PersonV5
    {
        private string firstName;
        private string lastName;
        private int age;
        private string ssn;
        private string secret;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value.Length > 1)
                {
                    this.firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value.Length > 1)
                {
                    this.lastName = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
            }
        }
        public string SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                if (value.Length == 10)
                {
                    this.ssn = value;
                }
            }
        }

        public PersonV5()
        {
            this.FirstName = "N/A";
            this.LastName = "N/A";
            this.Age = 0;
            this.SSN = "----------";
        }

        public PersonV5(string firstName, string lastName, int age, string ssn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.SSN = ssn;
        }

        public PersonV5(string fullname, int age, string ssn) : this(fullname.Split()[0], fullname.Split()[1], age, ssn)
        {
        }



        string FullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public void Present()
        {
            Console.WriteLine($"Hello, my name is {this.FullName()}");
            Console.WriteLine($"I am {this.Age} years old.");
            Console.WriteLine($"My social security number is: {this.SSN}");
        }
    }
}
