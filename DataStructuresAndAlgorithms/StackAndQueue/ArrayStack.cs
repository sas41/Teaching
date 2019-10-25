using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class ArrayStack<T>
    {
        const int array_size = 16;
        T[] ts = new T[array_size];
        int head = 0;

        public ArrayStack()
        {

        }

        public void Push(T item)
        {
            if (head < array_size)
            {
                ts[head] = item;
                head++;
            }
            else
            {
                throw new InvalidOperationException("Stack Full.");
            }
        }

        public T Pop()
        {
            if (head > 0)
            {
                head--;
                T item = ts[head];
                ts[head] = default(T);
                return item;
            }
            else
            {
                throw new InvalidOperationException("Stack Empty.");
            }
        }

        public T Peek()
        {
            if (head > 0)
            {
                return ts[head-1];
            }
            else
            {
                throw new InvalidOperationException("Stack Empty.");
            }
        }
    }
}
