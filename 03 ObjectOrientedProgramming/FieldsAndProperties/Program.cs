using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV3 personA = new PersonV3();

            personA.FirstName = "Gosho";
            personA.LastName = "Petrov";
            personA.Age = 30;
            personA.SSN = "9011058777";

            PersonV3 personB = new PersonV3();

            personB.FirstName = "Pesho";
            personB.LastName = "Petrov";
            personB.Age = 32;
            personB.SSN = "8806124589";

            personA.Present();
            Console.WriteLine();
            personB.Present();


            Console.WriteLine("====================");
            personB.FirstName = "P";
            personB.LastName = "P";
            personB.Age = -9;
            personB.SSN = "777";
            personB.Present();

            Console.ReadLine();
        }
    }
}
