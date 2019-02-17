using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    /// Concept: - Understanding difference between OBJECT and Variable
    ///          - Understand when memory get allocated.
    /// Question: What will be the result for below program?
    ///
    /// Answer:  100
    ///          1000
    public class Program2
    {
        static void Main(string[] args)
        {
        int[] a = new int[3];   // memory is allocated to 'a'
        a[1] = 10;              
        Object obj = a;         // Obj is pointer to above meomory
        int[] b = (int[])obj;   // 'b' is another pointer to 'a' itself 
        b[1] = 100;
        Console.WriteLine(a[1]);
        ((int[])obj)[1] = 1000;
        Console.WriteLine(a[1]);
        }
    }
}