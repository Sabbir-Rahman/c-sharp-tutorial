using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // expression ? true: false
            bool correct = true;

            int number = correct ? 10 : 0;

            Console.WriteLine(number);

        }
    }
}
