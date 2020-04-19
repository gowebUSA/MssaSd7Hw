using System;
//This exercise consists of building a mathematics  flash card simulator.You will have four \sets" of flash
//cards, addition, subtraction, multiplication, and division. To initialize a session, you will ask the users to
//select the type of problem they want too practice and the number of problems.You will echo the problem
//type and the number of problems to the user. See figure 1.

//When the user begins the test, the application will present the specified number of problems of the
//specified type.The problems will generate random integers between 1 and 12, or whatever range you choose.
//The application will keep score, and if the user misses a problem the application will display the correct
//answer to the problem. At the conclusion of the session the application will report the number of correctly
//answered questions and give a numeric score.See figugure 2.

//To help you get started, I have suggested some started code below. If you use this starter code (you do
//not have to, you can do this any way you choose), you will need to implement six methods: 

//Initialize(),
//Add(n), 
//Subtract(n), 
//Multiply(n), 
//Divide(n), and 
//Report(n1, n2). 
//All of these methods will return values.

//Please note the following: 

//(1) I have written the Subtract() method so that the answer is always
//a positive number, that is, the larger integer is on the left hand side of the operator and the smaller
//integer is on the right hand side of the operator. 

//(2) The Divide() method will return a floating point number, and you will have to use an approximate 
//answer to check for correctness. For example 3/7 = 0:42857142857142857142857142857143, but you would probably 
//accept 0:42 or 0:43 as correct.

//Ref: https://www.completecsharptutorial.com/basic/calling-method.php
//https://www.completecsharptutorial.com/basic/calling-method.php
//https://stackoverflow.com/questions/5728494/how-do-you-call-a-method-from-static-main
//https://www.quora.com/How-do-I-access-variable-of-main-method-from-another-method-within-the-same-class
//https://www.tutorialspoint.com/compile_csharp_online.php

namespace MathGames
{
    class Initialize
    {
        //public static int  Multiply()
        //{
        //    Console.WriteLine("Enter multiplicand: ");
        //    int multiplicand = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter multiplier: ");
        //    int multiplier = int.Parse(Console.ReadLine());

        //    int product = multiplicand * multiplier;
        //    return product;
        //}
        //public static float Divide()
        //{
        //    Console.WriteLine("Enter dividend: ");
        //    int dividend = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter divisor: ");
        //    int divisor = Convert.ToInt32(Console.ReadLine());

        //    float quotient = dividend / divisor;
        //    return quotient;
        //}
        //public static int Add()
        //{
        //    Console.WriteLine("Enter addend1: ");
        //    int addend1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter addend2: ");
        //    int addend2 = Convert.ToInt32(Console.ReadLine());

        //    int sum = addend1 + addend2;
        //    return sum;
        //}
        //public static int Subtract()
        //{
        //    Console.WriteLine("Enter minuend: ");
        //    int minuend = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter subtrahend: ");
        //    int subtrahend = Convert.ToInt32(Console.ReadLine());

        //    int diff = minuend - subtrahend;
        //    return diff;
        //}

        public static object Util { get; private set; }

        static void Main(string[] args)
        {
            Random r = new Random();
            int genRand = r.Next(2, 50);
            Console.WriteLine("Random Number = " + genRand);

            Console.WriteLine("Welcome to Math Games");
            Console.WriteLine("\nTo Multiply, enter 1 " + "\nTo Divide, enter 2 " + "\nTo Add, enter 3 " + "\nTo Subtract, enter 4 " + "\n Choose your problem type: ");
            int probType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of problems between 1 and 12: ");
            int numProb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are testing {probType} and you have {numProb} problems");
            Console.WriteLine("\nTo begin your test, enter values.");

            switch (probType)
            {
                case 1:
                    int multiplicand = genRand;
                    int multiplier = genRand;
                    Console.WriteLine($"Multiplicand is {multiplicand} and multiplier is {multiplier}");
                    int product = multiplicand * multiplier;
                    int ans = int.Parse(Console.ReadLine());
                    if (ans == product)
                    {
                        Console.WriteLine($"Your answer {ans} is correct.");
                    }
                    else
                    {
                        Console.WriteLine("Your answer is wrong.");
                    }
                    
                    break;
                case 2:
                    Console.WriteLine("Enter dividend: ");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter divisor: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());

                    float quotient = dividend / divisor;
                    Console.WriteLine($"The answer is {quotient}");
                    break;
                case 3:
                    Console.WriteLine("Enter addend1: ");
                    int addend1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter addend2: ");
                    int addend2 = Convert.ToInt32(Console.ReadLine());

                    int sum = addend1 + addend2;
                    Console.WriteLine($"The answer is {sum}");
                    break;
                case 4:
                    Console.WriteLine("Enter minuend: ");
                    int minuend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter subtrahend: ");
                    int subtrahend = Convert.ToInt32(Console.ReadLine());

                    int diff = minuend - subtrahend;
                    Console.WriteLine($"The answer is {diff}");
                    break;
                default: Console.WriteLine("Choose again");
                    break;
            }
            //int score = 0;
            //(probType, numProb) = Util.Initialize();
            //if (probType == 3)
            //{
            //    Initialize a = new Initialize();
            //    a.Add();
            //}
            //else if (probType == 4)
            //{
            //    Initialize s = new Initialize();
            //    s.Subtract();
            //}
            //else if (probType == 1)
            //{
            //    Initialize m = new Initialize();
            //    m.Multiply();
            //}
            //else if (probType == 2)
            //{
            //    Initialize d = new Initialize();
            //    d.Divide();
            //}
            //else
                //Console.WriteLine(" Sorry , you made an invalid choice. ");
            //string report = Util.Report(score, numProb);
            //Console.WriteLine(report);
            

        }
    }
}

//int score = 0;
//(probType, numProb) = Util.Initialize();
//            if (probType == 3)
//                score = Util.Add(numProb);
//            else if (probType == 4)
//                score = Util.Subtract(numProb);
//            else if (probType == 1)
//                score = Util.Multiply(numProb);
//            else if (probType == 2)
//                score = Util.Divide(numProb);
//            else
//                Console.WriteLine(" Sorry , you made an invalid choice. ");
//            string report = Util.Report(score, numProb);
//Console.WriteLine(report);
