using System;

namespace Key_ValueStore
{
    class MyDictionary
    {
        struct KeyValue
        {
            private int sValue;
            public int SValue
            {
                get => this.sValue;
            }
        }
    }
    class KeyValue7
    {
        struct KeyValue
        {
            public string key;
        };
        static void Main(string[] args)
        {
            KeyValue value;

            value.key = "Sample";

            Console.WriteLine("Key-Value Store");
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
