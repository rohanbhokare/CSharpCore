using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Intermediate
    /// Concept: Boxing Unboxing
    /// Question: what is the output of the following program.
    /// Answer: System.Byte
    ///         System.Int32
    public class Program12
    {
        public static void Main(string[] args)
        {
            byte b = 100;
            dynamic d = b;
            Console.WriteLine(d.GetType());
            d += 100;
            Console.WriteLine(d.GetType());
        }
    }
}