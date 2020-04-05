using System;
using System.Collections.Generic;

namespace VectorDistEx2B
{
    class VectorDist
    {
        public double Euclidean()
        {
            //dist = sqrt( ((x1 - x2)*2) + ((y1 - y2)*2) )
            Console.WriteLine("Euclidean Distance");
            double dist, x1, x2, y1, y2, sqr, sqrx, sqry;
            var random = new Random();
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 18, 25, 36, 48, 56, 61, 78, 89, 95, 100 };
            int index = random.Next(list.Count);

            Console.WriteLine(5);
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(1);
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(7);
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(4);
            y2 = Convert.ToDouble(Console.ReadLine());

            sqrx = (x1 - x2) * 2;
            sqry = (y1 - y2) * 2;

            sqr = sqrx + sqry;

            dist = Math.Sqrt(sqr);

            return dist;
        }

        public static void Main(string[] args)
        {
            //Ref: https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
            double x8, y8;
            var random = new Random();
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 18, 25, 36, 48, 56, 61, 78, 89, 95, 100  };
            int index = random.Next(list.Count);

            Console.WriteLine(8);
            x8 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Again");

            Console.WriteLine(5);
            y8 = Convert.ToDouble(Console.ReadLine());
            //
            //
            //
            //Ref: https://www.csharpens.com/c-sharp/c-sharp-program-for-pythagoras-theorem-108/
            Console.WriteLine("VectorDistEx2B");
            double d3, x, y, z, sqd3;

            Console.WriteLine("Enter X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Z: ");
            z = Convert.ToDouble(Console.ReadLine());

            sqd3 = (x * x) + (y * y) + (z * z);

            d3 = Math.Sqrt(sqd3);

            Console.WriteLine("3 Dimensional space is {0}", d3);
            //Euclidean(index);
        }
    }
}
