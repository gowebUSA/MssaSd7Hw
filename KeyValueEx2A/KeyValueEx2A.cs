using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Print a line above your iteration stating which data structure you're printing from, and print a 
//blank line between the last item in the collection and the description of the following data structure.

//Ref EX 2A: https://www.c-sharpcorner.com/UploadFile/d6fefe/generic-collection-classes-in-C-Sharp/
//Ref: C# book Page 419.

namespace ListKey
{
//1. In a new project, modify your Key-Value store from last week to use a generic type parameter rather than 
//typing your "value" instance field in `KeyValue` as an `object`.
    public class KeyValue
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public KeyValue(string k, int v)
        {
            this.Key = k;
            this.Value = v;
        }

//2. In a new project, instantiate an instance of each of the generic collection classes described in Chapter 18:
//-List<T>, LinkedList<T>, Queue<T>, Stack<T>, Dictionary<TKey, TValue>, SortedList<TKey, TValue>, and HashSet<T>).
        List<KeyValue> KeyList = new List<KeyValue>()

        //Insert 5 values of a type of your choosing into each of these collections, then iterate over the collection and 
        //print each value to the console. 
        {
        new KeyValue("Cows",47),
        new KeyValue("Dogs",17),
        new KeyValue("Cats",42),
        new KeyValue("Horses",10),
        new KeyValue("Pigs",5)
        };
    }
}
namespace KeyValueEx2A
{
    public class MyDictionary
    {
        public MyDictionary()
        {
            Dictionary<string, int> KeyValue = new Dictionary<string, int>();
            // fill the Dictionary
            KeyValue["Cows"] = 47;
            KeyValue["Dogs"] = 17;
            KeyValue["Cats"] = 42;
            KeyValue["Horses"] = 10;
            KeyValue["Pigs"] = 5;

            // Was #KeyValuePair, Console.WriteLine("The Dictionary contains:");, foreach    

        }
    }
    class KeyValueEx2A
    {
        public static IEnumerable<KeyValuePair<string, int>> KeyValue { get; private set; }
        static void Main()
        {
            //#KeyValuePair
            // iterate using a foreach statement
            // the iterator generates a KeyValuePair item
            Console.WriteLine("The Dictionary is using a List<T> generic type and contains:");
            foreach (KeyValuePair<string, int> element in KeyValueEx2A.KeyValue)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }
            //
            //
            Console.WriteLine("KeyValueEx2A EX 2A Mainline.");
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d[KeyValue]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{(int)d["Cats"]}, {(int)d["Dogs"]}");
        }
    }
}
