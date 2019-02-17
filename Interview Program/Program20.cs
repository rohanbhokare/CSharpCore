using System;

namespace CSharpCore.Interview_Program
{
    /// level: Intermediate
    /// concept: overloading
    /// Question: What is the output of following program.
    /// Answer: double array
    public class Program20
    {
        public Program20(Object o)
        {
            Console.WriteLine("Object");
        }
        public Program20(double[] dArray)
        {
            Console.WriteLine("double array");
        }
        public static void Main(string[] args)
        {
            new Program20(null);
        }
    }
}