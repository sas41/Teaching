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
            List<int> unsorted = new List<int>();

            Random rng = new Random();
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(rng.Next(1, 50));
            }
            Console.WriteLine("Original List:  " + string.Join(", ", unsorted));

            List<int> selectionSort = Sorting.SelectionSort(unsorted);
            Console.WriteLine("Selection Sort: "+string.Join(", ", selectionSort));


            List<int> bubbleSort = Sorting.BubbleSort(unsorted);
            Console.WriteLine("Bubble Sort:    " + string.Join(", ", bubbleSort));

            Console.ReadLine();
        }
    }
}
