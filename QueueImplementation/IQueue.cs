using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    public interface IQueue<T>
    {
        public T Peek();
        public void Enqueue(T element);
        public T Dequeue();
    }
}
