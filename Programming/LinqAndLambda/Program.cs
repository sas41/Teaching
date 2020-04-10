using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(word => int.Parse(word)).ToArray();

            int max = numbers.Max();
            int min = numbers.Min();
            int sum = numbers.Sum();
            double average = numbers.Average();

            int[] positives = numbers.Where(x => x >= 0).ToArray();
            int[] negatives = numbers.Where(x => x < 0).ToArray();

            int[] sortedAscending = numbers.OrderBy(x => x).ToArray();
            int[] sortedDescending = numbers.OrderByDescending(x => x).ToArray();

            int[] highestThree = numbers.OrderByDescending(x => x).Take(3).ToArray();
            int[] lowestThree = numbers.OrderBy(x => x).Take(3).ToArray();

            int[] highestThreeEven = numbers.Where(x => x % 2 == 0).OrderByDescending(x => x).Take(3).ToArray();
            int[] lowestThreeEven = numbers.Where(x => x % 2 == 0).OrderBy(x => x).Take(3).ToArray();

            //int[] lowestThree = numbers.OrderByDescending(x => x).Reverse().Take(3).ToArray();
        }
    }
}
