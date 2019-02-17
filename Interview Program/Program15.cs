using System;

namespace CSharpCore.Interview_Program
{
    /// level: basic
    /// Concept: Null printing.
    /// Queesiton: What is the output of following program
    /// Answer:  Value of i is
    /// Note if variable is null then it dosent print any value.
    public class Program15
    {
        public static void Main()
        {
            int? i = null;
            i++;
            Console.WriteLine("Value of i is {0} ", i);
        }     
    }
}