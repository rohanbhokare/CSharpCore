using System;

namespace CSharpCore.Interview_Program
{
    /// Level: Intermidate
    /// Concept: static members and static constructor
    /// Question: What is the output of following program
    ///
    /// Answer: TestValue: 10
    public class Program9
    {
        static void Main(string[] args)
        {
            TestStatic t = new TestStatic();
            t.Print();
        }
    }

    public class TestStatic
    {
        public static int TestValue;

        public TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }
        static TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }

        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine("TestValue : " + TestValue);

        }
    }


}