using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private int capacity;
        private int count;
        private T[] array;

        public ArrayQueue(int _capacity)
        {
            capacity = _capacity;
            array = new T[capacity];
        }

        /// <summary>
        /// Returns and removes the element at the end of the queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Dequeue()
        {
            T temp = array[0];
            if (count == 0) 
            {
                throw new ArgumentException("There is no elements in the queue!");
            }
            else
            { 
                for (int i = 0; i < count - 1; i++)
                {
                    array[i] = array[i + 1];
                }
            }

            count--;
            return temp;
        }

        /// <summary>
        /// Adds a new element at the end of the queue
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="ArgumentException"></exception>
        public void Enqueue(T element)
        {
            if (count == capacity)
            {
                throw new ArgumentException("Capacity is full!");
            }
            else
            {
                array[count] = element;
                count++;
            }
        }

        /// <summary>
        /// Returns the element at the end of the queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Peek()
        {
            T temp = array[0];
            if (count == 0)
            {
                throw new ArgumentException("There is no elements in the queue!");
            }

            return temp;
        }
    }
}
