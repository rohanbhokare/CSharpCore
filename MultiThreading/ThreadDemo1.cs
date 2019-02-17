using System;
using System.Threading;

namespace CSharpCore.MultiThreading
{
    public class ThreadDemo1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("current executing thread is " + Thread.CurrentThread.Name);

            Test1();
            Test2();
            Test3();
        }

        static void Test1()
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine("Test1: "+i);
            }
        }
        static void Test2()
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine("Test2: "+i);
                if(i == 50)
                {
                    Console.WriteLine("Main thread is sleeping");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main thread woke up");
                }
            }
        }
        static void Test3()
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine("Test3: "+i);
            }
        }
    }
}