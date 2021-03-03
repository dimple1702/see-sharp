using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<T> collection

            var list = new List<string>();
                // can also be added as new List<string>(){"Dimple","Deeksha","Himalaya"};
            
            list.Add("Dimple");     // Add specified value one after another
            list.Insert(0, "Deeksha");  // Insert the specified value at specified index
            list.Add("Himalaya");
            list.Add("Harman");
            list.Add("Parneet");
            list.Add("Reema");
            list.Add("Anku");

            list.Remove("Anku");  // Remove specified value from the list
            list.RemoveAt(4);    // Remove the value at specified index

            list.Sort(); // Sort the list

            Console.WriteLine("Second Item in the list is: " + list[1]);

            Console.WriteLine("\nList of names of the team: ");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Capacity of the list: " + list.Capacity);

            // HashSet<T> collection

            var hashSet = new HashSet<string>();
            hashSet.Add("DIM101");
            hashSet.Add("DEE102");
            hashSet.Add("HIM103");
            hashSet.Add("HAR104");

            Console.WriteLine("\nCode for each employee: ");
            foreach (var code in hashSet)
            {
                Console.WriteLine(code);
            }

            Console.ReadLine();
        }
    }
}
