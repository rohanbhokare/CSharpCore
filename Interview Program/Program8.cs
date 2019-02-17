namespace CSharpCore.Interview_Program
{
    /// level: Advance
    /// Concept: This keyword
    /// Question: Is there a way to modify ClassA 
    ///           so that you can call the constructor with parameter, 
    ///           when the Main method is called, 
    ///           without creating any other new instances of the ClassA
    ///
    ///           : this(10)
    class ClassA
    {
        // public ClassA(): this
        public ClassA() {
            
         }
        public ClassA(int pValue) { }
    }

    // At the client side:
    public class Program8
    {
        static void Main(string[] args)
        {
            ClassA refA = new ClassA();
        }
    }
}