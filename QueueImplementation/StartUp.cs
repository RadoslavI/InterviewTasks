namespace QueueImplementation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Demo code for the Queue implementation using Linked List
            Console.WriteLine("===== Results for Linked List Queue =====");
            LinkedListQueue<string> lq = new LinkedListQueue<string>();

            lq.Enqueue("Ivan");
            lq.Enqueue("Petar");
            lq.Enqueue("Dimitar");
            lq.Enqueue("Mario");

            Console.WriteLine(lq.Dequeue());
            Console.WriteLine(lq.Dequeue());
            Console.WriteLine(lq.Dequeue());
            Console.WriteLine(lq.Dequeue());

            try
            {
                Console.WriteLine(lq.Peek());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            //Demo code for the Queue Implementation using Array
            Console.WriteLine("\n===== Results for Array Queue =====");
            ArrayQueue<int> aq = new ArrayQueue<int>(5);

            aq.Enqueue(10);
            aq.Enqueue(20);
            aq.Enqueue(30);
            aq.Enqueue(40);
            aq.Enqueue(50);

            Console.WriteLine(aq.Dequeue());
            Console.WriteLine(aq.Dequeue());
            Console.WriteLine(aq.Dequeue());
            Console.WriteLine(aq.Dequeue());
            Console.WriteLine(aq.Dequeue());

            try
            {
                Console.WriteLine(aq.Dequeue());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
} 