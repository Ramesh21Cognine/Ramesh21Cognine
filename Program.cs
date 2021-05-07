using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            method1();
        }

        public static void method1()
        {
            m2();
        }

        private static void m2()
        {
            //throw new NotImplementedException();
            m3();
        }

        private static void m3()
        {
            Console.WriteLine("This is method 3 called");
        }
    }
}
