using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Add(5));

            DoNothing();

            PrintHello();

            Console.WriteLine();

            Console.Write("Pi = ");
            Console.WriteLine(GetPi());

            Console.WriteLine();
            Console.WriteLine("Enter a number to add 10 to: ");
            int test = ReadInt();
            Console.WriteLine(Add(10, test));

            Console.WriteLine();

            DoMathStuff();
        }

        static void DoNothing()
        {

        }

        static void PrintHello()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }

        static double GetPi()
        {
            return 3.1415926;
        }

        static int ReadInt()
        {
            string text = Console.ReadLine();
            int num = int.Parse(text);

            return num;
        }

        static int Add(int a, int b = 10)
        {
            return a + b;
        }

        static int Add(int a)
        { 
            return a +15;
        }

        static double Add(double a, double b)
        { 
            return a + b;
        }

        static void DoMathStuff()
        {
            Console.WriteLine("Doing math stuff...");
            
            Console.WriteLine("Enter a number: ");
            int n1 = ReadInt();
            
            Console.WriteLine("Enter another number: ");
            int n2 = ReadInt();
            
            int result = Add(n1, n2);

            Console.Write("Result: ");
            Console.WriteLine(result);
        }

    }
}
