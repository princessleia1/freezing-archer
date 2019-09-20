using System;

namespace inheritance_auto
{
    class Program
    {
        public class A
        {
            private int value = 10;
            // Private A.B is a nested class that derives from A, and C derives from A
            public class B : A
            {
                public int GetValue()
                {
                    return this.value;
                }
            }
        }

        // C derives from A        
        public class C : A
        {
            //    public int GetValue()
            //    {
            //        return this.value;
            //    }
        }

        // Private A.value field is visible in A.B 
        public class Example
        {
            public static void Main(string[] args)
            {
                var b = new A.B();
                Console.WriteLine(b.GetValue());
            }
        }
        // Example displays the following output:
        // 10
    }
}
