using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Intermediate
    // Concept: - Exceptional Handling
    /// Question: What will be the result for below program?
    ///
    /// Answer:  Hi
    ///          finally
    ///          10
    public class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine(return_value_check());
        }
        static int return_value_check()
        {
            try
            {
                Console.WriteLine("HI");
                return 10;
            }
            catch (Exception e)
            {
                return 5;
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }

    }
}