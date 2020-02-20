using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    static class Sorting
    {
        static List<int> Copy(List<int> list)
        {
            List<int> newCopy = new List<int>();
            
            foreach (var item in list)
            {
                newCopy.Add(item);
            }

            return newCopy;
        }

        static void Swap(List<int> list, int indexA, int indexB)
        {
            int numberA = list[indexA];
            int numberB = list[indexB];

            list[indexA] = numberB;
            list[indexB] = numberA;
        }

        public static List<int> SelectionSort(List<int> list)
        {
            List<int> sorted = Copy(list);
            int count = sorted.Count();

            for (int outerIndex = 0; outerIndex < count; outerIndex++)
            {
                int minIndex = outerIndex;

                for (int innerIndex = outerIndex; innerIndex < count; innerIndex++)
                {
                    if (sorted[innerIndex] < sorted[minIndex])
                    {
                        minIndex = innerIndex;
                    }
                }

                Swap(sorted, outerIndex, minIndex);

            }


            return sorted;
        }

        public static List<int> BubbleSort(List<int> list)
        {
            List<int> sorted = Copy(list);
            for (int i = sorted.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sorted[j] > sorted[j+1])
                    {
                        Swap(sorted, j, j + 1);
                    }
                }
            }

            return sorted;
        }
    }
}
