using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Program program = new Program();
            program.print();
        }

        void print()
        {
            Console.WriteLine("Hello World");
        }
    }
}