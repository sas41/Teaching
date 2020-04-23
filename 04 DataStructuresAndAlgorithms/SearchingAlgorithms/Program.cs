using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int> { 10, 15, 25, 35, 45, 55, 65 };

            Console.WriteLine("Linear Search:");
            Console.WriteLine(LinearSearch(test, 25));
            Console.WriteLine(LinearSearch(test, 40));

            Console.WriteLine("Binary (Iterative) Search:");
            Console.WriteLine(BinarySearch(test, 25));
            Console.WriteLine(BinarySearch(test, 40));

            Console.WriteLine("Binary (Recursive) Search:");
            Console.WriteLine(BinarySearchRecursive(test, 25, 0, test.Count-1));
            Console.WriteLine(BinarySearchRecursive(test, 40, 0, test.Count-1));

            Console.ReadLine();
        }

        static int LinearSearch(List<int> set, int search)
        {
            for (int i = 0; i < set.Count; i++)
            {
                if (set[i] == search)
                {
                    return i;
                }
            }

            return -1;
        }
        static int BinarySearch(List<int> set, int search)
        {
            int middle, start= 0, end = set.Count - 1;
            while (end >= start)
            {
                middle = (start + end) / 2;
                if (set[middle] == search)
                {
                    return middle;
                }
                else if (set[middle] < search)
                {
                    start = middle + 1;
                }
                else if (set[middle] > search)
                {
                    end = middle - 1;
                }
            }

            return -1;
        }
        static int BinarySearchRecursive(List<int> set, int search, int start, int end)
        {
            int middle;
            middle = (start + end) / 2;
            if (set[middle] == search)
            {
                return middle;
            }
            else if (end < start)
            {
                return -1;
            }
            else if (set[middle] < search)
            {
                return BinarySearchRecursive(set, search, middle + 1, end);
            }
            else if (set[middle] > search)
            {
                return BinarySearchRecursive(set, search, start, middle - 1);
            }

            return -1;
        }
    }
}
