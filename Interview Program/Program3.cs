using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic, 
    /// Concept: Generic Class
    /// Predict the output for below program
    ///
    /// Output: "Welcome to CsharpStar !!"
    ///
    ///
    public class Generic<T>
    {
        public T Field;
    }
    public class Program3
    {
        public static void Main(string[] args)
        {
            Generic<int> g2 = new Generic<int>();
            Generic<int> g3 = new Generic<int>();
            g2.Field = 8;
            g3.Field = 4;
            if (g2.Field % g3.Field == 0)
            {
                Console.WriteLine("Welcome to CsharpStar !!");
            }
            else
                Console.WriteLine("Prints nothing:");
            Console.ReadLine();
        }
    }
}