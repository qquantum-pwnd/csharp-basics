using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic output functions"); // title

            Console.WriteLine("beep");  // this is a comment
            Console.Beep(); // makes a beep sound in the  console
            Console.WriteLine("\tBeeped!");
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey(); // waits for a user input to proceed
            /*
             * this is an epic multiline omment
             */

            // variables

            Console.WriteLine("\nWorking With Variables"); // title #2

            Console.WriteLine();

            int x; // declaring a variable (integer)
            x = 715; // initializing a variable (integer)

            int y = 517; // declaring + initializing an integer number

            int z = x + y; // sum of the integer x and the integer y

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z); // prints out the sum of x + y (715 + 517)
            Console.WriteLine("715 + 517 is " + z);
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
           


            double a = 297.5;

            Console.WriteLine("\n" + a + " is a decimal number");
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
            bool b = true; // boolean; can only be true or false
            bool c = false;

            Console.WriteLine("\nBooleans can only contain the value " + b + " or " + c);
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();

            char symbol = '@'; // can only contain one character

            Console.WriteLine("\n The char variable can be used to display a single character, for example: " + symbol);
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();


            string user = "qquantum";
            string username = symbol + user;

            Console.WriteLine("\nCurrent user: "+username);
            Console.ReadKey();


            // Constants

            const double pi = 3.14159; // a constant's value gets declared at the start and cannot be changed

            Console.WriteLine("\nConstants");
            Console.WriteLine("\nThe first few digits of pi are "+pi);
            Console.WriteLine("\nPress Enter to continue");
            Console.ReadKey();
           
        }
    }
}
