using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Създаване ма Списък:
            List<int> myList = new List<int> ();
            
            // Добавяне на елемнти, ръчно.
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);
            myList.Add(30);
            myList.Add(35);
            myList.Add(15);


            // Изписване на елемнти:
            Console.WriteLine("Initial List:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"myList[{i}] = {myList[i]}");
            }
            
            // Махане на първото срещане на елемент с дадена стойност:
            myList.Remove(25);

            Console.WriteLine("After single removal:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"myList[{i}] = {myList[i]}");
            }

            // Махане на всички срещания на елемнт:
            while (myList.Contains(15))
            {
                myList.Remove(15);
            }

            Console.WriteLine("Current elements (While-Remove):");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Махане на елемент в даден индекс:
            myList.RemoveAt(0);
            Console.WriteLine("Current elements (RemoveAt):");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // Махни всички елементи от Списъка.
            myList.Clear();
        }
    }
}
