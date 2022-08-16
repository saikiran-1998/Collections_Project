using System;
using System.Collections.Generic;

namespace Dictionary_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionaries map keys to values. Keys must be unique

            Dictionary<string, string> companies = new Dictionary<string, string>();

            // add some keys and values to the dictionary
            companies.Add("Company1", "Employee1");
            companies.Add("Company2", "Employee2");
            companies.Add("Company3", "Employee3");
            companies.Add("Company4", "Employee4");
            companies.Add("Company5", "Employee5");
            ////to print dictionary

            //foreach (var item in companies)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}
            // use the Count property to see how many items there are
            Console.WriteLine("Count : {0} ", companies.Count);

            // Trying to add an existing key will throw an exception
            // companies.Add("Company5", "Employee5"); //it gives exception as key already exists
            // companies.Add("Company6", "Employee5"); //it works because value can be duplicated

            // The TryAdd function makes it convenient to see if there's a duplicate
            Console.WriteLine(companies.TryAdd("Company5", "Employee5")); // returs false and didn't throw exception
            Console.WriteLine(companies.TryAdd("Company6", "Employee6")); // will add the key value pair to dictionary ,
                                                                          // if key doesn't exists and returns tru
            Console.WriteLine("Count : {0} ", companies.Count);
            // Dictionaries are also like associative arrays
            Console.WriteLine("value of Company6 is : {0 } ", companies["Company6"]);

            // This way, setting an existing key just overwrites the value
            companies["Company6"] = "Employee6-1";
            Console.WriteLine("value of Company6 is : {0 } ", companies["Company6"]);
            // See if the Dictionary contains an key or a value

            Console.WriteLine("companies Dictionary contains a key : {0} ",companies.ContainsKey("company1"));
            Console.WriteLine("companies Dictionary contains a value : {0} ", companies.ContainsValue("Employee6-1"));

            // Remove items
            companies.Remove("Company6");
            Console.WriteLine(companies.Count);
        }
    }
}
