using System;
using System.Collections.Generic;

namespace Queue_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an empty Queue that holds strings
            Queue<string> myQueue = new Queue<string>();

            // Add items to the end of the queue
            myQueue.Enqueue("one");
            myQueue.Enqueue("two");
            myQueue.Enqueue("three");
            myQueue.Enqueue("four");
            myQueue.Enqueue("five");

            // use the count property to see how many items there are

            Console.WriteLine("Count {0} ", myQueue.Count);
            // Queues can be iterated without changing the structure
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            // peek at the front of the queue
            string queueElement = myQueue.Peek();
            Console.WriteLine(queueElement);
            Console.WriteLine("Count {0} ", myQueue.Count);

            // remove items from the front of the queue
            queueElement = myQueue.Dequeue();
            Console.WriteLine(queueElement);
            Console.WriteLine("Count {0} ", myQueue.Count);
            queueElement = myQueue.Dequeue();
            Console.WriteLine(queueElement);
            Console.WriteLine("Count {0} ", myQueue.Count);

            // see if the queue contains an item
            Console.WriteLine(myQueue.Contains("one"));
            Console.WriteLine(myQueue.Contains("two"));
            Console.WriteLine(myQueue.Contains("three"));

            // Remove all the items
            myQueue.Clear();
            Console.WriteLine("Count {0} ", myQueue.Count);
        }
    }
}
