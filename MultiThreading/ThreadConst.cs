using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
   
    internal class ThreadConst
    {
      //  static void Test()
       // {
       //     for (int i = 1; i <= 100; i++)
       //     {
         //       Console.WriteLine("Test1 " + i);
         //   }
       // }

        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
        }
        static void Main()
        {
            //   ThreadStart obj = new ThreadStart(Test);
            //   ThreadStart obj = Test;
             //  Anonymus method //  ThreadStart obj = delegate() { Test(); };
       //Lamda opreation//Lemda exp ression
           //  ThreadStart obj = () => Test();

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);

            Thread t = new Thread(obj);
           t.Start(75);
            Console.ReadLine();
        }
    }
}
