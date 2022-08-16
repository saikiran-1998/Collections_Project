using System;
using System.Collections.Generic;

namespace List_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define some strings to add to the list
            string[] names = { "sai", "kiran", "vamsi" };
            // TODO: Create the list

            List<string> lstString = new List<string>();

            // TODO: Add some elements to the list from an existing array
            lstString.AddRange(names);

            // TODO: Add individual items
            lstString.Add("String4");

            // TODO: Examine the Count and Capacity
            Console.WriteLine("count and Capacity {0} ,{1}",lstString.Count,lstString.Capacity,lstString);

            // TODO: Enumerate the items in the list with a foreach loop
            foreach (var item in lstString)
            {
                Console.WriteLine(item);
            }

            // TODO: Access any item by its index
            Console.WriteLine("Print list with index {0} ",lstString[2]);

            // TODO: Sort the list content
            lstString.Sort();
            foreach (var item in lstString)
            {
                Console.WriteLine(item);
            }

            // TODO: Remove items from the list
            //lstString.Remove("kiran");
            //lstString.RemoveAt(2);
            Console.WriteLine("count and Capacity {0} ,{1}", lstString.Count, lstString.Capacity, lstString);


            // ** Searching List Content **/

            // TODO: Determine if a list contains a given item
            Console.WriteLine(lstString.Contains("Sai"));

            // TODO: The Exists function gives us a more customizable way to search
            // by using a predicate function to examine each element in the list

            Console.WriteLine(lstString.Exists(l=>l.Length<3));
            Console.WriteLine(lstString.Exists(l => l.Contains("a")));
            // TODO: Use the Find function to search through items

            string str = string.Empty;
            str = lstString.Find(l=>l.StartsWith('s'));
            Console.WriteLine(str);
            // TODO: The FindAll function can find multiple items
            List<string> lstItems = new List<string>();
            lstItems  = lstString.FindAll(l=>l.ToLower().StartsWith('s'));
            foreach (var item in lstItems)
            {
                Console.WriteLine(item);
            }
            // TODO: Use TrueForAll to see if a given condition is true for all elements
            Console.WriteLine(lstString.TrueForAll(l=>l.Length>=3));
            Console.WriteLine(lstString.TrueForAll(l => l.Length < 2));            
        }
    }
}
