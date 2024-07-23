using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class ThreadDemo2
    { 
    
        static void test1()
        {
            for(int i=1; i<=50; i++)
        {
                Console.WriteLine("Test1 " +i);
        }
            Console.WriteLine("Thread 1 is exiting");
        }

        static void test2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test2 " + i);
                if (i == 50)
                {
                    Console.WriteLine("Test2 is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 2 woke up");
                }
            }
            Console.WriteLine("Thread 2 is exiting");
        }

        static void test3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Test3 " + i);

            }
            Console.WriteLine("Thread 3 is exiting");
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);  
            Thread t3 = new Thread(test3);
            t1.Start();
            t2.Start(); 
            t3.Start();
            Console.WriteLine("Thread  main is exiting");
        }
    }
}
