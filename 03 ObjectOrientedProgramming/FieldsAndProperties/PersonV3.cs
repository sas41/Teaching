using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    class PersonV3
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
                if(value.Length > 1)
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
