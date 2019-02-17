using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    // Concept: - Understanding difference between OBJECT and Variable
    ///          - Understand when memory get allocated.
    /// Question: What will be the result for below program?
    ///
    /// Answer:  5
    ///          5
    ///          10
    public class Program5
    {
        static void methodOne(int[] a)
        {
            int[] b = new int[5];

            a = b;

            Console.WriteLine(a.Length);

            Console.WriteLine(b.Length);
        }
        public static void Main(string[] args)
        {
            int[] a = new int[10];

            methodOne(a);

            Console.WriteLine(a.Length);
        }
    }
}