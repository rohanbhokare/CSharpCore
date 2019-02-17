using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Basic
    // Concept: - Understanding of default value assigned to type
    /// Question: What will be the result for below program?
    ///
    /// Answer:  location is null
    ///          01/01/0001 00:00:00
    public class Program6
    {
        static string location;
        static DateTime time;

        static void Main()
        {
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
        }

    }
}