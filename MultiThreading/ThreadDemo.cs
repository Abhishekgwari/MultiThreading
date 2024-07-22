using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class ThreadDemo
    {
        static void test1()
        {
            for (int i = 1; i <= 100; i++)
            
                Console.WriteLine("Test 1 "+ i);
            
        }

        static void test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test 2 " + i);
                if (i == 50)
                {
                    Console.WriteLine("Main thread going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main thread Woke up");
                }
                   
            }
        }
        static void test3()
        {
            for (int i = 1; i <= 100; i++)
            
                Console.WriteLine("Test 3 " + i);
            
        }
        static void Main()
        {
            test1();
            test2();
            test3();
        }
    }
}
