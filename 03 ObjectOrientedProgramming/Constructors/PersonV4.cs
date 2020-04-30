using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class PersonV4
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
                return firstName;
            }
            set
            {
                if (value.Length > 1)
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 1)
                {
                    lastName = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
        public string SSN
        {
            get
            {
                return ssn;
            }
            set
            {
                if (value.Length == 10)
                {
                    ssn = value;
                }
            }
        }

        public PersonV4()
        {
            FirstName = "N/A";
            LastName = "N/A";
            Age = 0;
            SSN = "----------";
        }

        public PersonV4(string fn, string ln, int a, string num)
        {
            FirstName = fn;
            LastName = ln;
            Age = a;
            SSN = num;
        }

        public PersonV4(string fullname, int a, string num) : this(fullname.Split()[0], fullname.Split()[1], a, num)
        {
        }



        string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void Present()
        {
            Console.WriteLine($"Hello, my name is {FullName()}");
            Console.WriteLine($"I am {Age} years old.");
            Console.WriteLine($"My social security number is: {SSN}");
        }

    }
}
