using System;

namespace TestGit02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Yasser");
            Console.WriteLine("Mian (in Dev Branch");

            TestClass tc = new TestClass();

            Console.WriteLine(tc.x);
            tc.x = 200;
            Console.WriteLine(tc.x);
        }
    }
}
