using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class ThreadLocking
    {                             //    When multiple thread want To access a method but at that moment
                                  //    we get unexpected output so we use thread locking
        public void Display()
        {
            lock (this)
            {
                Console.Write("Csharp is an   ");
                Thread.Sleep(5000);
                Console.WriteLine("Object oriented Language ");
            }
        }

        static void Main()
        {
           ThreadLocking obj = new ThreadLocking();

          Thread t1 = new Thread (obj.Display);
            Thread t2 = new Thread(obj.Display); 
            Thread t3 = new Thread(obj.Display);
            t1.Start();
            t2.Start();
            t3.Start();
 
           
            Console.ReadLine(); 
        }
    }
}
