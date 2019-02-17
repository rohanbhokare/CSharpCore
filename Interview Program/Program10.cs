using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    /// Concept: Logic Building
    /// Question: Write a program to Multiply two numbers without using * operator
    public class Program10
    {
        public static int MulWithoutStarOperator(int numb1, int numb2)
        {
            int value = 0;
            for(int z=1; z <= numb2; z++)
            {
                value = value + numb1; 
            }
            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MulWithoutStarOperator(4,5));

        }
    }
}