using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Sabbir";
            person.LastName = "Rahman";

            Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();

            switch (fullNameGuess)
            {
                case "Sabbir Rahman":
                    Console.WriteLine("You are so right");
                    break;
                case "Sabbir":
                    Console.WriteLine("You are close");
                    break;
                default:
                    Console.WriteLine("Bad performence");
                    break;
            }

        }
    }
}
