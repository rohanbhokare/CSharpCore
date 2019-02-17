using System;

namespace CSharpCore.Interview_Program
{
    /// level: basic
    /// concept: polyphormism
    /// Question: What is output of following program.
    /// Answer class2
    public class Program14
    {
        public static void Main()
        {
            class1 a = new class3();
            Console.WriteLine(a.DoSomething());
        }

        public class class1
        {
            public virtual string DoSomething()
            {
                return "class1";
            }
        }

        public class class2 : class1
        {
            public override string DoSomething()
            {
                return "class2";
            }
        }

        public class class3 : class2
        {
            public new string DoSomething()
            {
                return "Class3";
            }
        }
    }
}