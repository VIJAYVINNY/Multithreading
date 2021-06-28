using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace ExceptionHandling
{
    class Multithreading
    {
        static void Test1()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Test2:" + i);
            }
            Console.WriteLine("Thread 1 is completed:");
        }

        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread 1 is completed:");
        }

        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("Thread 3 is completed:");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            Test1(); Test2(); Test3();
        }
    }
}
