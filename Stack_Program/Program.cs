using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an empty stack
            Stack<string> myStack = new Stack<string>();

            // TODO: The Push function pushes new elements onto the stack
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("four");
            myStack.Push("five");

            // TODO: The Count property indicates how many elements are on the stack

            Console.WriteLine("Count {0}", myStack.Count);
            // TODO: Stacks can be enumerated in place without changing the content
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            // TODO: The Peek function examines the current top element but does not remove it
            string topElement = myStack.Peek();
            Console.WriteLine(topElement);
            Console.WriteLine("Count {0}", myStack.Count);
            // TODO: The Pop function removes an element from the top
            topElement = myStack.Pop();
            Console.WriteLine(topElement);
            Console.WriteLine("Count {0}", myStack.Count);

            // TODO: Search for an element using Contains
            Console.WriteLine(myStack.Contains("five"));
            Console.WriteLine(myStack.Contains("four"));
        }
    }
}
