using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    /// Concept: CompareTo
    /// Question: Predict the output of below program
    ///
    /// Answer: -1;
    ///
    public class Program4
    {
        static void Main(string[] args)
        {
             string a = "CsharpStar";
             string b = "CSHARPSTAR";
            //string a = new Program3();
            //Program3 b = new Program3();
            int c;
            c = a.CompareTo(b); // if same it returns 0, if different it returns -1
            
            
            Console.WriteLine(c);
        } 
    }
}