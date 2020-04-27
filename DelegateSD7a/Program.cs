using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSD7a
{
    class Program
    {
        public delegate int WorkPerformHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            Console.WriteLine("DelegateSD7a and Events");
            Console.WriteLine("Ref: https://app.pluralsight.com/course-player?clipId=94e47ac6-874f-4e55-bed9-4f5c9a3dbaaf");

            WorkPerformHandler del1 = new WorkPerformHandler(WorkPerformed1);
            WorkPerformHandler del2 = new WorkPerformHandler(WorkPerformed2);
            WorkPerformHandler del3 = new WorkPerformHandler(WorkPerformed3);

            //del1(5, WorkType.Code);
            //del2(7, WorkType.GoToMeetings);

            //DoWork(del2);

            //MulticastDelegate
            del1 += del3 + del2;            //Delegates

            int finalHours = del1(7, WorkType.Code);         //Invocation List

            Console.WriteLine(finalHours);

            Console.Read();
        }
        static void DoWork(WorkPerformHandler del)
        {
            del(8, WorkType.GenerateReports);
        }
        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called." + hours.ToString());
            return hours + 1;
        }
        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called." + hours.ToString());
            return hours + 2;
        }
        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called." + hours.ToString());
            return hours + 3;
        }
        public enum WorkType
        {
            GoToMeetings,
            Code,
            GenerateReports
        }
    }
}
