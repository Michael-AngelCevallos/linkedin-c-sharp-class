
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
            // Console.WriteLine("Hello World!");

            // // #8 - ASK USER FOR THEIR NAME USING CONSOLE.WRITELINE
            // Console.WriteLine("What is your name?");

            // // #9 - Create a String Variable that takes in the users answer, Do this by using a Console.ReadLine
            // string name = Console.ReadLine();

            // //#10 - Return message to console that says hello + users input
            // Console.WriteLine("Hello " + name + "!");

//==========================================================================

    // VARIABLES 

    // #1 - Declare some basic value variable types
    int integer = 10;
    float f = 2.0f;
    decimal d = 10.0m;
    bool b = true;
    char c = 'c';

    // #2 - Declare a string, 's' in string must be lowercase(And incased within quotations(""))
    string str = "I am a string";

    // #3 - Declare an IMPLICIT Variable(A VARIABLE THAT IS DECLARED WITH VAR, NOT SPECIFIED LIKE ABOVE) - Using the Keyword 'var' you can declare a variable and when ran, the program will figure out what variable was meant to be used for you
    var x = 10;
    var z = "Hello!";

    // #4 - Declare An ARRAY - List of values, declared by using the square barcket notation ([])
    int[] vals = new int[5];
    string[] strings = {"one","two","three"};

    // #5 - Prints out values of arrays to the console. This will print out TYPE of Array to console. This Is NOT what we want
    // Console.WriteLine(vals);
    // Console.WriteLine(strings);

    // #6 - Print Out messages to console using Formating String. A Console WriteLine that declares message without variables directely within console writeline
    Console.WriteLine("{0},{1},{2},{3},{4}");








        }
    }
}
