using System;

namespace CSharpCore.Interview_Program
{
    /// level: basic
    /// concept: ref vs out
    /// Question what is the output of following program
    /// Answer : 6 16
    public class Program19
    {
        public static void Main(string[] args)
        {
            int i = 3;
            int j;
            method1(ref i);
            method2(out j);               
            Console.WriteLine(i + " " + j);
        }
 
        static void method1(ref int x)
        {
            x = x + x;
        }
        static void method2(out int x)
        {
            x = 4;
            x = x * x;
        }
    }
}