using System;

namespace RecursiveMethods
{
    class RecursiveMethods
    {
        /*
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(Fibonacci(i));
                //ref: www.dotnetperls.com/fibonacci

            }
        }
        */
        static int Main(string[] args)
        {

            int n, i = 0, c;
            Console.WriteLine("Enter the number of terms:");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Fibonacci series\n");

            for (c = 1; c <= n; c++)
            {
                int result = FibonacciFunction(i);
                Console.Write(result + " ");
                i++;
            }
            Console.WriteLine();
            return 0;
        }

        public static int FibonacciFunction(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (FibonacciFunction(n - 1) + FibonacciFunction(n - 2));
            }
        }
        //ref: stackoverflow.com/questions/9828762/print-a-string-of-fibonacci-recursively-in-c-sharp
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("\n\tRecursiveMethods.Program.Main()");
        //}

    }
}

