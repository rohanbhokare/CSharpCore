using System;

namespace CSharpCore.Interview_Program
{
    public class Program11
    {
        /// Level: Intermediate
        /// Concept: Maths Functions (How much candidate know C#)
        /// Question: what is the output of the following program.
        /// Answer: 6
        ///         10
        public static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(6.5));
            Console.WriteLine(Math.Round(9.5));
            // Note It returns nearest even number in above case.
        }
    }
}