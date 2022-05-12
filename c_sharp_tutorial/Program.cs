using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types
            int a = -5;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 10;
            // only b will change
            Console.WriteLine(a);
            Console.WriteLine(b);

            //reference type
            int[] c = { 5 };
            int[] d = c;

            Console.WriteLine(c[0]);
            Console.WriteLine(d[0]);

            d[0] = 10;

            Console.WriteLine(c[0]);
            Console.WriteLine(d[0]);
        }

    }
}