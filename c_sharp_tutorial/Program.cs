using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sabbir";
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };
            string greeting = new string(chars);
            // output will hello
            Console.WriteLine(greeting);

            string message = $"Hello my name is {name} and I say all of you {greeting}";
            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.Length);
        }

    }
}
