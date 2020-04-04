using System;
using System.Collections.Generic;
using System.Text;
using Key_ValueStore;

//Create a basic key/value store:
//Ref EX 1B: https://github.com/iamchristmas/MSSA/blob/master/KeyValue/KeyValueStore.cs/
//Ref EX 2A: https://www.c-sharpcorner.com/UploadFile/d6fefe/generic-collection-classes-in-C-Sharp/


namespace KeyValueAssignment
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Key-ValueStore");
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
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

namespace Key_ValueStore
{
//1. Create a struct named `KeyValue` which contains one `string` "key" and one `object` "value" as `public readonly` 
//instance fields
    public struct KeyValue                      //iamchristmas
    {
        public readonly string Key;
        public readonly int Value;

//2. Implement a constructor for `KeyValue` which sets the instance fields
        public KeyValue(string k, int v)
        {
            Key = k;
            Value = v;
        }
    }

//3. Create a class named `MyDictionary` which contains one array of KeyValue structs and one `int` to keep track of the 
//number of stored values as private instance fields.You may choose a reasonable fixed size for the array. 
    public class MyDictionary                   //iamchristmas
    {
//4. Implement an indexer which takes a string (key) and returns an object (value).
        private KeyValue[] store;
        private int count;
        public MyDictionary()
        {
            store = new KeyValue[2];
            count = 0;
        }
//-The `set` property should search the array for the given key and replace the KeyValue with a `new 
//-----KeyValue(...)` if it exists.If the key does not exist, it should be added as a `new KeyValue(...)`.
//-The `get` property should search the array for the given key and return the associated value if it exists.If 
//-----the key does not exist, the property should throw a KeyNotFoundException.
        public int Count { get; set; }
        public int this[string key]
        {
            get => FindKeyValue(key);
            set
            {
                try
                {
                    store[FindKeyValue(key)] = new KeyValue(key, value);
                }
                catch
                {
                    store[count] = new KeyValue(key, value);
                    count++;
                }
            }
        }
//5. Your code should compile against the following `Main` method and print a KeyNotFoundException followed by the 
//line "42, 17" to the command line.
        public int FindKeyValue(string k)               //iamchristmas
        {
            for (int i = 0; i < count; i++)
            {
                if (store[i].Key == k) return store[i].Value;
            }
            throw new KeyNotFoundException();
        }
    }
    
}
