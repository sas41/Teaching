using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_01_10
{
    public class CustomStack
    {
        int current;
        int[] data;

        public CustomStack(int size)
        {
            current = 0;
            data = new int[size];
        }
        public void Push(int item)
        {
            data[current] = item;
            current++; // current = current + 1;
        }
        public int Pop()
        {
            current = current - 1;
            int element = data[current];
            return element;
        }
        public int Peek()
        {
            return data[current - 1];
        }
    }
}
