using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаване на масив.
            int[] myNumbers = new int[5];

            // Записване в масив.
            myNumbers[0] = 10;
            myNumbers[1] = 50;
            myNumbers[2] = 800;
            myNumbers[3] = 16;
            myNumbers[4] = 9;

            //Четене от масив.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            // Задача:
            // Чети N от конзолата, чети N брой градове.
            // Чети още един град, и провери да ли е в масива.

            // Чети числото "N" от конзолата.
            int n = int.Parse(Console.ReadLine());

            // Създай масив "cities" за string с "N" брой места.
            string[] cities = new string[n];

            // От 0 до N-1
            for (int i = 0; i < n; i++)
            {
                // Чети градове и го пази в "cities".
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine("Cities:");
            Console.WriteLine(string.Join(", ", cities));

            Console.WriteLine("Enter a City to search:");

            // Чети търсения град.
            string search = Console.ReadLine();
            // Bool за да знаем да ли сме я намерили търсения
            // град в масива.
            bool found = false;

            // За всеки елемент (item) в cities.
            foreach (string item in cities)
            {
                // Провери да ли си съвпада с търсения град.
                if (item == search)
                {
                    // Ако да, промени found, на истина.
                    found = true;
                }
            }

            // Ако found е истина, действай относно.
            if (found)
            {
                Console.WriteLine("The City has been found.");
            }
            else
            {
                Console.WriteLine("The City was not found.");
            }

            Console.ReadLine();
        }
    }
}
