using System;

namespace EX6AManipulatingArray
{
    class EX6A
    {
        public void sumAveElements(int[] arr, int size)
        {
            //-----------------------------sumAveElements----------------------------------------------------------------
            int sum = 0;
            int average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine($"Sum Of Array is : {sum}");
            Console.WriteLine($"Average Of Array is : {average}");
            Console.ReadLine();
        }
        //---------------------------------GetReverse------------------------------------------------------------
        public static string GetReverse(string input)
        {
            string output = "";
            for (int i = 1; i <= input.Length; i++)
            {
                output += input[input.Length - i];
            }
            return output;
        }
        //---------------------------------RotatingArray------------------------------------------------------------
        static void leftRotate(int[] arr3, int d, int n)  //d- is how many char we need to rotate, 
        {                                                //n- is the size of the array
            for (int i = 0; i < d; i++)
                leftRotatebyOne(arr3, n);
        }

        static void leftRotatebyOne(int[] arr3, int n)   //n- is the size of the array
        {
            int i, temp = arr3[0];                       //temp is where we place d temporarily
            for (i = 0; i < n - 1; i++)                 //while we shift the rest of tyhe array to the left.
                arr3[i] = arr3[i + 1];

            arr3[i] = temp;
        }
        /* utility function to print an array */
        static void printArray(int[] arr3, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr3[i] + " ");
        }
        //----------------------------//SortingArray()-----------------------------------------------------------------
        public static void sortT<T>(T[] arr4, int index)
        {

            // If the index is negative,  
            // it represents the bitwise 
            // complement of the next larger  
            // element in the array. 
            if (index < 0)
            {
                index = ~index;

                if (index == 0)
                    Console.Write("beginning of array");
                else
                    Console.Write("{0} and ", arr4[index - 1]);
                if (index == arr4.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine("{0}", arr4[index]);
            }
        }
        //=========================================================Main()====================================================================
        public static void Main(string[] args)
        {
            //----------------------------//sumAveElements()-----------------------------------------------------------------
            Console.WriteLine("sumAveElements");
            int size = 5;
            //Console.WriteLine("Enter the Size :");
            //size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter the Elements of the Array : ");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int len = a.Length;
            EX6A pg = new EX6A();
            pg.sumAveElements(a, len);

            //----------------------------//GetReverse()-----------------------------------------------------------------
            Console.WriteLine("ReverseString");
            Console.WriteLine("Enter string to reverse: ");
            string testString = Console.ReadLine();
            Console.WriteLine(GetReverse(testString));


            //----------------------------//RotatingArray()-----------------------------------------------------------------
            //Driver code
            Console.WriteLine("\nRotating Array A");
            int[] arr3 = { 0, 2, 4, 6, 8, 10 };  //{ 1, 2, 3, 4, 5, 6, 7 }
            leftRotate(arr3, 2, 6);              //leftRotate(arr, 2-how many char to rotate, 7-the size of the array );     
            printArray(arr3, 6);                 //printArray(arr, 7-size of the array);

            Console.WriteLine("\nRotating Array B");
            int[] arr3a = { 1, 3, 5, 7, 9 };  
            leftRotate(arr3a, 2, 5);                
            printArray(arr3a, 5);



            //----------------------------//SortingArray()-----------------------------------------------------------------
            // array elements 
            Console.WriteLine("\nSorting Array");
            string[] arr4 = new string[5] { "1", "3", "9", "5", "7" };    //{ "A", "D", "X", "G", "M" }

            foreach (string g in arr4)
            {
                Console.WriteLine(g);
            // display original array 
            }

            Console.WriteLine("\nAfter Sort:");
            Array.Sort(arr4);

            foreach (string g in arr4)
            {
                Console.WriteLine(g);
            // display sorted array 
            }

            Console.WriteLine("\n2 sorts between :");

            // binary Search for "B" 
            int index = Array.BinarySearch(arr4, "2");

            // call "sortT" function 
            // which is the Sort<T>(T[]) function 
            sortT(arr4, index);

            Console.WriteLine("\n4 sorts between :");
            index = Array.BinarySearch(arr4, "4");
            sortT(arr4, index);
        }
    }
}
