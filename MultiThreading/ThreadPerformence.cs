using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace MultiThreading
{
    internal class ThreadPerformence
    {
        public static void IncrementCounter1()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000000; i++)
            
                Count++;
                Console.WriteLine("IncrementCounter1 " + Count);
            
        }

        public static void IncrementCounter2()
        {
            long Count = 0;
            for (long i = 0; i <= 10000000000; i++)
            
                Count++;
                Console.WriteLine("IncrementCounter2 " + Count);
            
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);


            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            
            s1.Start();
            IncrementCounter1 ();
            IncrementCounter2 ();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();


            t1.Join();
            t2.Join();
            Console.WriteLine("Time taken to complete by single threaded model " + s1.ElapsedMilliseconds);

            Console.WriteLine("Time taken to complete by Multi threaded model " + s2.ElapsedMilliseconds);
            Console.ReadLine();

        }

    }
}
