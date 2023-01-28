using System.Linq.Expressions;
using System.Xml;

namespace StackImplementation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Demo code for the Stack Implementation using Linked List
            Console.WriteLine("===== Results for Linked List Stack =====");
            ListStack<string> lq = new ListStack<string>();
            lq.Push("Ivan");
            lq.Push("Petar");
            lq.Push("Dimitar");
            lq.Push("Mario");
            Console.WriteLine(lq.Pop());
            Console.WriteLine(lq.Pop());
            Console.WriteLine(lq.Pop());
            Console.WriteLine(lq.Pop());
            try
            {
                Console.WriteLine(lq.Peek());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);   
            }
            
            //Demo code for the Stack Implementation using Array
            Console.WriteLine("\n===== Results for Array Stack =====");
            ArrayStack<int> arrStack = new ArrayStack<int>(4);

            arrStack.Push(1);
            arrStack.Push(11);
            arrStack.Push(111);
            arrStack.Push(1111);
            try
            {
                arrStack.Push(1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(arrStack.Pop());
            Console.WriteLine(arrStack.Peek());
            Console.WriteLine($"Count {arrStack.Count}");
        }
    }
}