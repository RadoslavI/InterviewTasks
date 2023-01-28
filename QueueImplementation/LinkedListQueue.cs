using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private LinkedList<T> list;

        public LinkedListQueue()
        {
            list = new LinkedList<T>();
        }

        /// <summary>
        /// Adds a new element at the end of the queue
        /// </summary>
        /// <param name="element"></param>
        public void Enqueue(T element)
        {
            list.AddLast(element);
        }

        /// <summary>
        /// Returns and removes the element at the end of the queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Dequeue()
        {
            if (list.Count > 0)
            {
                T temp = list.First!.Value;
                list.RemoveFirst();
                return temp;
            }
            else
            {
                throw new ArgumentException("The Queue is empty!");
            }
        }

        /// <summary>
        /// Returns the element on the end of the queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public T Peek()
        {
            if (list.Count > 0)
            {
                return list.First!.Value;
            }
            else
            {
                throw new ArgumentException("The Queue is empty!");
            }
        }
    }
}
