using System;

namespace HW5D
{
    class Hw5D
    {
        //public static void WhileLoop()
        //{
        //    Console.WriteLine("Odd numbers from 1 to 11. Prints one number per line using while loop.");
        //    int n = 0;
        //    while (n < (11 + 1 ))
        //    {
        //        if (n % 2 != 0)
        //        {
        //            Console.WriteLine(n.ToString());
        //        }
        //        n++;
        //    }

        //}
        public static void IntParse()
        {
            string g = "1";
            Console.WriteLine("\nPrint {g} from string to int.");
            Console.WriteLine(int.Parse(g));
            Console.WriteLine("Done");


        }
        public static void DoLoop()
        {
            Console.WriteLine("Odd numbers from 1 to 11. Prints one number per line using do loop.");
            int n = 0;
            do
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
                n++;
            } while (n < (11 + 1));
            


        }
        public static void WhileLoop()
        {
            Console.WriteLine("Odd numbers from 1 to 11. Prints one number per line using while loop.");
            int n = 1;
            while (n < (11 + 1))
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
                n++;
            }

        }
        public static void Main()
        {
            //ref: www.w3resource.com/csharp-exercises/basic/csharp-basic-exercise-25.php
            Console.WriteLine("Odd numbers from 1 to 11. Prints one number per line using for loop.");
            for (int n = 1; n < (11 + 1) ; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
            WhileLoop();
            DoLoop();
            IntParse();

        }
    }
}
