
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

        // #4 - This is Our Main Function - ALSO THE ENTRY POINT TO THE CODE
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
