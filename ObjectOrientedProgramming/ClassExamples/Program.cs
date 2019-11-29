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
            Person gosho = new Person();
            gosho.Name = "Gosho";
            gosho.SSN = "1111115500";
            gosho.YearOfBirth = 2011;

            gosho.PrintInfo();

            Person pesho = new Person("Pesho", "1234567890", 2012);
            string peshoInfo = pesho.GetInfo();

            Console.WriteLine(peshoInfo);

            Console.ReadLine();
        }
    }
}