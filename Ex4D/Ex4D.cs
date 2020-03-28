using System;

namespace Ex4D
{
    class Ex4D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex4D.Program.Main()");
            int r;
            r = -1;
            while (r > 0)
            {
                int Ans = r * r;
                Console.WriteLine($"Multiply r = {r} by itself is equals to: {Ans}");
            }

            r = 0;
            Console.WriteLine($"Cannot multiply r because r is less than 0. So r is = to: {r}");
                       
        }
    }
}
