using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpCore.Interview_Program
{
    /// level: basic
    /// concept: Collection
    /// Question: What is the output of the following program.!--
    /// Answer: 10,20,30,40,50,60
    public class Program13
    {
        public static  void Main()
        {
            var list = new List<int> { 10, 20, 30, 40, 50 };
            var collection = new Collection<int>(list);
            list.Add(60);
            Console.WriteLine(String.Join(",", collection));
        }
    }
}