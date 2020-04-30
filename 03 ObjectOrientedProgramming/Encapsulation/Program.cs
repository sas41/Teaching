using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonV5 test = new PersonV5("Pesho Petrov", 21, "9903127078");
            test.Present();

            Console.ReadLine();
        }
    }
}
