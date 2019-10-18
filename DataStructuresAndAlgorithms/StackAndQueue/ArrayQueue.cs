using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    class ArrayQueue<T>
    {
        const int array_size = 16;
        T[] ts = new T[array_size];
        int head = 0;
        int tail = 0;
        public ArrayQueue()
        {

        }

        public void Enqueue(T item)
        {
            if (tail < array_size)
            {
                ts[tail] = item;
                tail++;
            }
            else
            {
                throw new StackOverflowException("Queue Full.");
            }
        }

        public T Dequeue()
        {
            if (head != tail)
            {
                T item = ts[head];
                ts[head] = default(T);

                head++;

                if (head == tail)
                {
                    head = 0;
                    tail = 0;
                }

                return item;
            }
            else
            {
                throw new InvalidOperationException("Queue Empty.");
            }
        }

        public T Peek()
        {
            if (head != tail)
            {
                return ts[head];
            }
            else
            {
                throw new InvalidOperationException("Queue Empty.");
            }
        }

        public bool IsEmpty()
        {
            return head == tail;
        }
    }
}
