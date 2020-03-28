using System;

namespace MonteCarlo
{//namespace
    class MonteCarlo
    {//class
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        static void Main(string[] args)
        {
            MonteCarlo generator = new MonteCarlo();
            double x = generator.RandomNumber(0, 1);
            double y = generator.RandomNumber(0, 1);
            double hypo;

            //double side1, side2, hypo;
            Console.Write($"Side 1 : {x}");
            x = Convert.ToDouble(x);
            Console.Write($"\nSide 2 : {y}");
            y = Convert.ToDouble(y);
            hypo = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("\nHypotenuse : " + hypo);
            Console.ReadKey();

            Console.WriteLine("MonteCarlo.Program.Main()======NOT WORKING");
            //ref: www.csharp-console-examples.com/general/c-calculating-hypotenuse-of-a-triangle/
            //ref: www.c-sharpcorner.com/article/generating-random-number-and-string-in-C-Sharp/
        }
    }//class
}//namespace
