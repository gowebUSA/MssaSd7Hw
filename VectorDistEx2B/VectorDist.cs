using System;
using System.Collections.Generic;
//1. Introduction to exercise

//5. Fourth part, 100 points
//Write a function that takes two three-dimensional points and computes the Euclidean distance between
//them.Then, write a function that iterates through your collection, compares each point to every other point
//and reports the closest two points.Your output for the three point vectors might look like gure 2.
namespace VectorDistEx2B
{
    class VectorDist
    {
        public double Euclidean()
        {
            //2. First part, In the first two parts, we will find the two closest two-dimensional vectors, modeled as points in a two-
            //dimensional space. Write a console application that creates some sort of data structure that contains two
            //integers, x and y, as random numbers between 1 and 100. Do not use the built-in class Point, rather, build
            //your own data structure.Please note, we will think of these objects as points, but in reality they are vectors.
            //Then, create some sort of collection that contains 100 of these points.
            //3. Second part, 80 points
            //Write a function that takes two points and computes the Euclidean distance between them.Then, write
            //a function that iterates through your collection, compares each point to every other point and reports the
            //closest two points.

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

            //4. Third part, 90 points
            //In the second two parts, we will find the two closest three-dimensional vectors, modeled as points in a three-
            //dimensional space.Write a console application that creates some sort of data structure that contains three
            //integers, x, y, and z, as random numbers between 1 and 1000. Do not use any built-in class but build your
            //own data structure.Please note, we will think of these objects as points, but in reality they are vectors.
            //Then, create some sort of collection that contains 1000 of these points..

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
