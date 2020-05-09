using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvParser
{
    //Ref: https://github.com/ccc31807/ISTA421/blob/master/exercises/ProgStrSplitCsv.cs
    class Program
    {
        private static List<string> getCSV(string input)
        {
            //getCSV({input}
            int len = input.Length;
            List<string> rv = new List<string>();
            bool inQuote = false;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                int charcd = (int)input[i];
                //{input[i]} {charcode} {inQuote} [{sb.ToString()}]
                //if out-quote and character is ", change to in-quote
                //ASCII code 34 is quote ( " ).
                if (inQuote == false && charcd == 34)
                {
                    inQuote = true;
                }
                //if in-quote and character is " (ASCII 34), change to out-quote
                else if (inQuote == true && charcd == 34)
                {
                    inQuote = false;
                }
                //if in-quote, append char to SB
                else if (inQuote == true && charcd != 34)
                {
                    sb.Append(input[i]);
                }
                //if out-quote and comma, add SB to RV and clear SB
                else if (inQuote == false && charcd == 44)
                {
                    rv.Add(sb.ToString());
                    sb.Clear();
                }
                else if (inQuote == false && charcd != 44)
                {
                    sb.Append(input[i]);
                }
                else
                    Console.WriteLine($"WARNING, ERROR, == {input[i]} {charcd} {inQuote} [{sb.ToString()}]");
            }
            rv.Add(sb.ToString());
            return rv;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*************************
            * read CSV with embedded commas
            * parse CSV into separate fields and
            * ignore commas within quoted string
            * ***********************/
            Console.WriteLine("Reading CSV with embedded commas");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            myList.Add(input1);
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            myList.Add(input2);
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," +
            "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," +
            "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input3);
            foreach (string s in myList)
            {
                Console.WriteLine($"Current input is {s}");
                List<string> output = getCSV(s);
                int len = output.Count;
                Console.WriteLine($"This line has {len} fields. They are:");
                foreach (string s1 in output)
                    Console.WriteLine(s1);
            }
        }
    }
}
