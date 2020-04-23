using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV2 personA = new PersonV2();

            personA.FirstName = "Gosho";
            personA.LastName = "Petrov";
            personA.Age = 30;
            personA.SSN = "9011058777";

            PersonV2 personB = new PersonV2();

            personB.FirstName = "Pesho";
            personB.LastName = "Petrov";
            personB.Age = 32;
            personB.SSN = "8806124589";

            personA.Present();
            Console.WriteLine();
            personB.Present();

            Console.ReadLine();
        }
    }
}
