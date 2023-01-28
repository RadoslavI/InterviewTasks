using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    public interface IStack<T>
    {
        public T Peek();
        public T Pop();
        public void Push(T element);
    }
}
