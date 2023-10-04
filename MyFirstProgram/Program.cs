// Dennis Briffa (NET23).

// Tells the compiler that I want to use the System namespaces, makes the code more readable.
using System;

// Namespace is for structuring code, navigating easier and organization.
namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)

        {   // int is a fundamental type of variable and holds a simple number, no decimals.
            int i = 15;

            if (i > 10) Console.WriteLine("Talet är stort!");
            else Console.WriteLine("Oj. Lågt tal!");

            Console.ReadKey();

            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");

            // Waits for user to make an input in console before resume.
            Console.ReadKey();

            // A while loop is to repeat said task over and over, here it repeats until the value "i" is met.

            int counter = 0;
            while (counter <= i)
            {
                Console.WriteLine(counter);

                counter++;
            }
        }
    }
}