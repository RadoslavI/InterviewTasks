using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public class ListStack<T> : IStack<T>
    {
        private LinkedList<T> list;

        public ListStack()
        {
            list = new LinkedList<T>();
        }

        /// <summary>
        /// Returns the element on the top of the stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Peek()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The stack is empty!");
            }

            return list.Last();
        }

        /// <summary>
        /// Returns the count of the elements in the stack
        /// </summary>
        public int Count { get { return list.Count(); } }

        /// <summary>
        /// Returns and removes the element on the top of the stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The stack is empty!");
            }

            T temp = list.Last();
            list.RemoveLast();
            return temp;
        }

        /// <summary>
        /// Adds a new element on the top of the stack
        /// </summary>
        /// <param name="element"></param>
        public void Push(T element)
        {
            list.AddLast(element);
        }
    }
}
