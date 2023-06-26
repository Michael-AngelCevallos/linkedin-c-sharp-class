
// #1 - using System; - indicates that our program will be using code that is 
// in the .Net Namespace
using System;


// #2 - Namespace - Help organize programs, and prevent names that are in your
// code from colliding with names that are in other third party libraries you might
// include later OR in .NET itself <----
namespace HelloWorld
{
    // #3 - class - C# and .Net as a whole, is an Object Oriented Language, meaning all of your code is organized into classes. The PROGRAM class is where the MAIN function goes <----- * ALWAYS
    class Program{

        // #4 - This is Our Main Function - ALSO THE ENTRY POINT TO THE CODE. When you run the program, it will run whatever code is in here, and/or connecteed to here!
        static void Main(string[] args)
        {
            // #5 Console - represents a terminal object
            //#6 WriteLine - is a function/method - prints a string to the terminal
            // #7 - VERY IMPORTANT !!! IN C# YOU MUST END WITH SEMI-COLON OR CODE WILL CRASH!!!!!!!<-------
            Console.WriteLine("Hello World!");

            // #8 - ASK USER FOR THEIR NAME USING CONSOLE.WRITELINE
            Console.WriteLine("What is your name?");

            // #9 - Create a String Variable that takes in the users answer, Do this by using a Console.ReadLine
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

        }
    }
}
