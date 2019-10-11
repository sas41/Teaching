using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class ArrayList<T>
    {
        static int initial_capacity = 2;

        private T[] array;
        public int Count { get; private set; }

        public ArrayList()
        {
            array = new T[initial_capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return array[index];
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
                    array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Add(T newItem)
        {
            if (Count == array.Length)
            {
                Expand();
            }
            array[Count] = newItem;
            Count++;
        }

        public T RemoveAt(int ind)
        {
            if (ind > -1 && ind < Count)
            {
                T val = array[ind];

                ShiftBack(ind);
                Count--;

                if (Count <= array.Length / 4)
                {
                    Shrink();
                }

                return val;
            }

            throw new ArgumentOutOfRangeException();
        }

        public void Expand()
        {
            T[] biggerArray = new T[array.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                biggerArray[i] = array[i];
            }
            array = biggerArray;
        }

        public void Shrink()
        {
            T[] smallerArray = new T[array.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                smallerArray[i] = array[i];
            }
            array = smallerArray;
        }

        private void ShiftBack(int startIndex)
        {
            for (int i = startIndex; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }
    }
}
