using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Pow(9999, 999999999);
            Console.WriteLine(double.IsInfinity(a));
        }

    }
}