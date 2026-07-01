using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public class Collections
    {
        // arrays --> collections of similar data types 
        // arrays length is fixed   

        //int[] arr = new int[5];  // fixed length array

        // insert search sorting reverse on arrays --> DSA

        // DSA --> coding

        // collections --> Insert search reverse sort ops --> made easy
        // collections --> insert dynamically no lenth --> (dynamic arrys)

        // Generic & non Gen collection


        // Generic collection --> type safe collection
        // List, HashSet ,sortedSet, Dictionary, Queue, Stack  , lnkedlist

        public static void ListEx()
        {
            // List is gen coll
            // Store , remove , insert, search, sort, reverse , traverse

            List<string> names = new List<string>();
            List<bool> bools = new List<bool>();

            List<int> list = new List<int>();
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(21233);
            list.Add(3);
            list.Add(23423423);
            list.Add(25);
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(21233);
            list.Add(3);
            list.Add(23423423);
            list.Add(25);
            list.Add(34523);
            list.Add(23213);
            list.Add(2321);
            list.Add(2123);
            list.Add(221);
            list.Add(2213);
            list.Add(2123);
            list.RemoveAt(0);
            list.Remove(3);
            list.Insert(0, 123);
            int[] arr = { 35 };

            // for loop 

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void HashSetEx()
        {
            // HashSet is gen coll
            // Store , remove , insert, search, sort, reverse , traverse
            HashSet<string> names = new HashSet<string>();
            HashSet<bool> bools = new HashSet<bool>();
            HashSet<int> list = new HashSet<int>();
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(21233);
            list.Add(3);
            list.Add(23423423);
            list.Add(25);
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(21233);
            list.Add(3);
            list.Add(23423423);
            list.Add(25);

            // for loop 
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void sortedSetEx()
        {
            // sortedSet is gen coll
            // Store , remove , insert, search, sort, reverse , traverse
            SortedSet<string> names = new SortedSet<string>();
            SortedSet<bool> bools = new SortedSet<bool>();
            SortedSet<int> list = new SortedSet<int>();
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(21233);
            list.Add(3);
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(23);
            list.Add(43);
            list.Add(456);
            list.Add(25463);
            list.Add(456);
            list.Add(21233);
            list.Add(3);
            list.Add(23423423);
            list.Add(25);
            // for loop 
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void NonGen() { 
        ArrayList list = new ArrayList();
            list.Add(23);
            list.Add(34.5);
            list.Add("hi");
            list.Add(true);

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
        }
    }
}