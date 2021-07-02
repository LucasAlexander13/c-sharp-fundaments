using System;

namespace Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            String fname, lname;
            Console.Write("Enter your first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lname = Console.ReadLine();
            Console.WriteLine($"Your name is {fname} {lname}.");
        }
    }
}
