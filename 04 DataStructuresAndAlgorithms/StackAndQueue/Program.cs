using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueueTest();
            StackTest();
        }

        static void StackTest()
        {
            ArrayStack<int> myQueue = new ArrayStack<int>();
            ArrayStack<StringBuilder> myQueue2 = new ArrayStack<StringBuilder>();
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                int input = int.Parse(Console.ReadLine());
                myQueue.Push(input);
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                total = total + myQueue.Peek();
                Console.WriteLine(myQueue.Pop());
            }

            Console.WriteLine();
            Console.WriteLine(total);
        }

        static void QueueTest()
        {
            ArrayQueue<int> myQueue = new ArrayQueue<int>();
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                int input = int.Parse(Console.ReadLine());
                myQueue.Enqueue(input);
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                total = total + myQueue.Peek();
                Console.WriteLine(myQueue.Dequeue());
            }

            Console.WriteLine();
            Console.WriteLine(total);
        }
    }
}
