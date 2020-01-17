using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursiveFactorial(5));
            
            Console.WriteLine();

            List<int> data = new List<int>() { 5, 15, 12, 65, 24, 9 };

            Console.WriteLine(SumList(data));

            Console.WriteLine(RecursiveSum(data));


            string test = new string('#', 5);

            Console.ReadLine();
        }

        static int RecursiveFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * RecursiveFactorial(n - 1);
        }

        static int SumList(List<int> data)
        {
            int total = 0;
            foreach (int item in data)
            {
                total += item;
            }

            return total;
        }

        static int RecursiveSum(List<int> data)
        {
            Console.Write(data[0] + " + ");
            PrintList(data.GetRange(1, data.Count - 1));

            if (data.Count == 1)
            {
                return data[0];
            }

            return data[0] + RecursiveSum( data.GetRange(1,data.Count-1) );
        }

        static void PrintList(List<int> data)
        {
            Console.WriteLine("{ " + string.Join(", ", data) + " }");
        }

        static void RecursivePrint(int n)
        {
            if (n != 0)
            {
                Console.WriteLine(new string('*', n));

                RecursivePrint(n - 1);

                Console.WriteLine(new string('#', n));
            }
        }
    }
}
