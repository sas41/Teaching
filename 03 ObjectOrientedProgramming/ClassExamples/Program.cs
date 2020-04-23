using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV1 test = new PersonV1();

            test.FirstName = "Gosho";
            test.LastName = "Petrov";
            test.Age = 30;
            test.SSN = "9011058777";

            //test.Secret = "My secret is...";

            Console.WriteLine($"Hello, my name is {test.FirstName} {test.LastName}");
            Console.WriteLine($"I am {test.Age} years old.");
            Console.WriteLine($"My social security number is: {test.SSN}");

            Console.ReadLine();
        }
    }
}