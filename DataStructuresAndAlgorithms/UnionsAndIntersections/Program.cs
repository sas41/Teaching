using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionsAndIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listA = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> listB = new List<int>() { 4, 5, 6, 7, 8 };
            
            // Union
            List<int> union = new List<int>();
            union.AddRange(listA);
            foreach (var item in listB)
            {
                if (!(union.Contains(item)))
                {
                    union.Add(item);
                }
            }
            Console.WriteLine("Union:");
            Console.WriteLine(string.Join(", ", union));

            // Intersection
            List<int> intersection = new List<int>();
            foreach (var item in listA)
            {
                if (listB.Contains(item))
                {
                    intersection.Add(item);
                }
            }
            Console.WriteLine("Intersection:");
            Console.WriteLine(string.Join(", ", intersection));


            // Difference
            List<int> difference = new List<int>();
            foreach (var item in listA)
            {
                if (!(listB.Contains(item)))
                {
                    difference.Add(item);
                }
            }

            foreach (var item in listB)
            {
                if (!(listA.Contains(item)))
                {
                    difference.Add(item);
                }
            }
            Console.WriteLine("Difference:");
            Console.WriteLine(string.Join(", ", difference));

            Console.ReadLine();
        }
    }
}
