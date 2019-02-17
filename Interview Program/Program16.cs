using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    /// Concept: Basic
    /// Quesiton: what is the output of following program.
    /// Answer: ABC easy as System.Char[].

    public class Program16
    {
        public static void Main(string[] args)
        {
            string letters = "ABC";
            char[] numbers = { '1', '2', '3' };
            Console.WriteLine(letters + " easy as " + numbers);
        }
    }
}