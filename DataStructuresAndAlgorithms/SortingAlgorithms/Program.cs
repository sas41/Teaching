using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int> {4, 7, 9, 1, 6, 0, 8, 2, 3, 5 };

            List<int> sorted = Sorting.SelectionSort(unsorted);

            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}
