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
            list.Add("Dimple");
            list.Add("Deeksha");
            list.Add("Himalaya");
            list.Add("Harman");
            list.Add("Parneet");
            list.Add("Reema");

            Console.WriteLine("List of names of the team: ");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

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
