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

            Console.WriteLine(person.GetFullName());
        }

    }
}
