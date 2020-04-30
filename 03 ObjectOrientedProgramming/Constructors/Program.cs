using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> myList = new List<int>();
            PersonV4 test = new PersonV4();
            test.Present();

            Console.WriteLine();

            test = new PersonV4("Gosho", "Georgiev", 29, "9101295057");
            test.Present();

            Console.WriteLine();

            test = new PersonV4("Pesho Petrov", 21, "9903127078");
            test.Present();

            Console.ReadLine();
        }
    }
}
