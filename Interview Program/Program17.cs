using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Intermediate
    /// Concept: basic
    /// Question: What is the output of following program.!--
    /// Answer: StackOverflowException.
    public class Program17
    {
        static void Main(string[] args)
        {
            work();
            Console.WriteLine("Hello");
        }
        private static void work()
        {
            try
            {
                work();
            }
            finally
            {
                work();
            }
        }
    }
}