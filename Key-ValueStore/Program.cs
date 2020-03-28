using System;

namespace Key_ValueStore
{
    class Program
    {
        static void Main(string[] args)
        {
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
