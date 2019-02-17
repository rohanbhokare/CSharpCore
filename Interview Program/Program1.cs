using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    /// Concept: array
    /// Question: What happen when you compile and run the below program.
    ///
    /// Answer: Unhandled Exception: 
    ///         System.IndexOutOfRangeException: Index was outside the bounds of the array.

    public class Program1
    {
        static void Main(string[] args)
        {
            int[] i = new int[0];
            Console.WriteLine(i[0]);
        }
    }
}