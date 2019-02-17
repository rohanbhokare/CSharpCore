using System;
using System.Threading;

namespace CSharpCore.MultiThreading
{
    public class ConstructorOfThreadClass
    {
        // static void Test()
        // {
        //     for (int i=0; i <=50; i++)
        //     {
        //         Console.WriteLine(@"Test: {0}",i);
        //     }
        // }

        static void Test(object max)
        {
            int value = Convert.ToInt32(max);
            for (int i=0; i<value; i++)
            {
                Console.WriteLine(@"Test: {0}", i);
            }
        }

        static void Main(string[] args)
        {
            //ThreadStart obj = new ThreadStart(Test); 
            //Thread t = new Thread(obj);
            // Above was implicitly doing by CLR in previous example.
            // Above 2 statement is equal to following commented statement
            // Thread t = new Thread(Test);
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test);

            Thread t = new Thread(obj);
            t.Start(10);
            
            //t.Start();
            Console.ReadLine();
        }
    }
}