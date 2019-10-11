using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int first = int.Parse(input);

            input = Console.ReadLine();
            int second = int.Parse(input);

            int result = first + second;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
