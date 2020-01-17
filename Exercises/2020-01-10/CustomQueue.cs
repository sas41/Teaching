using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_01_10
{
    class CustomQueue
    {
        int head;
        int tail;
        int[] data;
        public CustomQueue(int size)
        {
            head = 0;
            tail = 0;
            data = new int[size];
        }
        public void Enqueue(int item)
        {
            data[tail] = item;
            tail++;
        }
        public int Dequeue()
        {
            int element = data[head];
            head++;
            return element;
        }
        public int Peek()
        {
            return data[head];
        }

    }
}
