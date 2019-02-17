using System;
using System.Threading;

namespace CSharpCore.MultiThreading
{
    public class ThreadDemo2
    {
        static void Test1()
        {
            for(int i=1;i<=50;i++)
            {
                Console.WriteLine(@"Test 1: {0}", i);
            }
            Console.WriteLine(@"Thread 1 is exiting.");
        }
        static void Test2()
        {
            for(int i=1;i<=50;i++)
            {
                Console.WriteLine(@"Test 2: {0}", i);
                if(i == 25)
                {
                    Console.WriteLine("Thread2 is sleeping");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread2 woke up");
                }
            }
            Console.WriteLine(@"Thread 2 is exiting.");
        }
        static void Test3()
        {
            for(int i=1;i<=50;i++)
            {
                Console.WriteLine(@"Test 3: {0}", i);
            }
            Console.WriteLine(@"Thread 3 is exiting.");
        }

        static void Main()
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);

            T1.Start();
            T2.Start();
            T3.Start();

            Console.WriteLine(@"Main Thread is exiting.");

        }
    }
}