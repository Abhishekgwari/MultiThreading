using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading                                 // join method in multi threading
{
    internal class JoinMethThread
    {
        static void Test1()
        {
            Console.WriteLine(" Thread 1 is starting");
            for (int i = 1; i <= 50; i++)
            Console.WriteLine("Test1 :" + i);
            Thread.Sleep(5000);
            Console.WriteLine(" Thread 1 is Exiting");
        }
        static void Test2()
        {
            Console.WriteLine(" Thread 2 is starting");
            for (int i = 1; i <= 50; i++)

                Console.WriteLine("Test2 :" + i);
            Console.WriteLine(" Thread 2 is Exiting");
        }
        static void Test3()
        {
            Console.WriteLine(" Thread 3 is starting");
            for (int i = 1; i <= 50; i++)

                Console.WriteLine("Test3 :" + i);
            Console.WriteLine(" Thread 3 is Exiting");
        }
        static void Main(string[] args)
            {
            Console.WriteLine("Main thread Started");


            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();                    // Main thread cant exit the program until child thread end
            Console.WriteLine("Main thread Exiting");
        }

        }
    }

