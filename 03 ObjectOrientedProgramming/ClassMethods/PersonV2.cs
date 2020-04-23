using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class PersonV2
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string SSN;
        string secret;

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
