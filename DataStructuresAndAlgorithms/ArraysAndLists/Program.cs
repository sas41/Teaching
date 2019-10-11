using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListTest();
            LinkedListTest();
            Console.ReadLine();

        }


        private static void LinkedListTest()
        {
            LinkedList<string> customList = new LinkedList<string>();

            customList.Add("Test Line 1");
            Console.WriteLine(customList.Count);
            Console.WriteLine(customList[0]);

            customList.Add("Test Line 2");
            Console.WriteLine(customList.Count);
            Console.WriteLine(customList[2]);
        }

        private static void ArrayListTest()
        {
            ArrayList<string> customList = new ArrayList<string>();

            customList.Add("Test 1");
            customList.Add("Test 2");
            customList.Add("Test 3");
            customList.Add("Test 4");
            customList.Add("Test 5");

            customList.RemoveAt(0);
            customList.RemoveAt(0);
            customList.RemoveAt(0);


            ///////////////////////////////////

            int[] oldArr = new int[] { 1, 2, 3, 4 };
            int[] newArr = new int[8];

            ///////////////////////////////////

            oldArr = newArr;

            ///////////////////////////////////

            newArr[0] = 99;

            Console.WriteLine(newArr[0]);
            Console.WriteLine(oldArr[0]);
        }

    }
}
