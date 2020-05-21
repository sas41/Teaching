using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldsPropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int test = int.Parse("199");


            PersonV6 test = new PersonV6("Gosho", "Georgiev", 29, "9101295057");
            Console.WriteLine(PersonV6.Count);

            test = new PersonV6("Pesho Petrov", 21, "9903127078");
            Console.WriteLine(PersonV6.Count);

            test = new PersonV6();
            Console.WriteLine(PersonV6.Count);



            foreach (var person in PersonV6.People)
            {
                person.Present();
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
