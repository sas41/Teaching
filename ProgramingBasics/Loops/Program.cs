using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop: 0 to 9
            Console.WriteLine("From 0 to 9");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // For loop: 10 to 1
            Console.WriteLine("From 10 to 1");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // For loop: 0 to N
            Console.WriteLine("From 0 to N");
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }


            // While loop: Increase by two
            int sum = 0;
            while (sum < 1000)
            {
                sum = sum + 2;
                Console.WriteLine(sum);
            }


            // While loop: Random
            Random rng = new Random();
            int number = 0;
            while (number != 41)
            {
                number = rng.Next(1, 500);
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
