using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class ArrayStack<T> : IStack<T>
    {
        private int capacity;
        private int count;
        private T[] array;

        public ArrayStack(int _capacity)
        {
            capacity = _capacity;
            array = new T[capacity];
            count = 0;
        }

        /// <summary>
        /// Returns the Count of the elements in the stack
        /// </summary>
        public int Count { get { return this.count; } }

        /// <summary>
        /// Returns the element on the top of the stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Peek()
        {
            if (count == 0) 
            {
                throw new ArgumentException("The stack is empty");
            }

            return array[count - 1];
        }

        /// <summary>
        /// Returns and removes the element on the top of the stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Pop()
        {
            if (count == 0)
            {
                throw new ArgumentException("The stack is empty");
            }

            T temp = array[count - 1];
            count--;
            return temp;
        }

        /// <summary>
        /// Adds a new element on the top of the stack
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="ArgumentException"></exception>
        public void Push(T element)
        {
            if (count == capacity)
            {
                throw new ArgumentException("Capacity is full");
            }

            array[count] = element;
            this.count++;
        }
    }
}
