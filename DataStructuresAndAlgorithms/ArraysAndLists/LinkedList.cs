using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Node<T>
    {
        public T value;
        public Node<T> next;
        public Node(T val, Node<T> nxt = null)
        {
            value = val;
            next = nxt;
        }
    }
    class LinkedList<T>
    {
        Node<T> start;
        public int Count { get; private set; }

        public LinkedList()
        {

        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    Node<T> current = start;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.next;
                    }
                    return current.value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < Count)
                {
                    Node<T> current = start;
                    for (int i = 0; i < index; i++)
                    {
                        current = current.next;
                    }
                    current.value = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
            if (start == null)
            {
                start = new Node<T>(item);
                Count = 1;
            }
            else
            {
                Node<T> current = start;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node<T>(item);

                Count++;
            }
        }
    }
}
