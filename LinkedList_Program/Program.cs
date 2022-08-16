using System;
using System.Collections.Generic;

namespace LinkedList_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define some strings that represent song names
            string[] names = { "sai", "kiran", "vamsi", "string4" };

            // TODO: Create a LinkedList that holds strings
            LinkedList<string> lstStrings = new LinkedList<string>(names);

            // TODO: Items can be added at the front or back of the list
            lstStrings.AddFirst("SatringFirst");
            lstStrings.AddLast("SatringLast");
            // TODO: Like other collections, a LinkedList can be iterated
            //foreach (var item in lstStrings)
            //{
            //    Console.WriteLine(item);
            //}

            // TODO: First and Last properties return LinkedListNodes
            LinkedListNode<string> first = lstStrings.First;
            LinkedListNode<string> last = lstStrings.Last;
            //Console.WriteLine(first.Value);
            //Console.WriteLine(last.Value);

            // TODO: Items can be added or removed relative to an existing item
            lstStrings.AddAfter(first, "String added using addafter");
            lstStrings.AddBefore(first, "String added using addbefore");
            //lstStrings.AddAfter("String added using addafter","sai");
            foreach (var item in lstStrings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------------------------------------------------------");
            lstStrings.Remove("sai");
            //lstStrings.RemoveFirst();
            //lstStrings.RemoveLast();
            foreach (var item in lstStrings)
            {
                Console.WriteLine(item);
            }

            // TODO: Search for items in the list with Contains and Find
            Console.WriteLine(lstStrings.Contains("s"));
            Console.WriteLine(lstStrings.Contains("sai"));
            Console.WriteLine(lstStrings.Find("string")); //it will return the LinkedListNode type
            // TODO: The list can then be traversed with those properties
            Console.WriteLine(first.Next.Value);
            Console.WriteLine(last.Previous.Value);
           // Console.WriteLine(first.Next);
        }
    }
}
