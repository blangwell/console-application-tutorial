// using is the c# import statement
using System;

namespace consoleApplicationTutorial
{
    class Program
    {
        // void in C# means this method returns nothing
        // Main must be capital to be seen as app entry point
        static void Main(string[] args)
        {
            // Console class belongs to System
            // Console.WriteLine("Hello world!");
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f; // must append f
            var character = 'A'; // characters go in single quotes
            var firstName = "Barent"; // strings go in double quotes
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }


    }
}

// to declare a variable in C# we start with the type
// int number;
// const float Pi = 3.14f; can't define const without setting value
// to use a word that clashes with C# keywords, use @ => @int

// Pascal Case: FirstName
// Hungarian Notation: strFirstName (preface identifier with type)

// conventions:
// local variables: camelCase , constants PascalCase

// double is the default data type used by compiler for real numbers
// if you want to use float, you must add f suffix:
// float number = 1.2f
// decimal => decimal number = 1.2m

// Overflowing
// byte number = 255;
// we exceed the boundary of bytes datatype
// C# does not have default overflow checking
// number = number + 1; => 0

// if you use checked keyword, program will throw an exception instead of overflowing
// checked
// {
//     byte number = 255;
//     number = number + 1;
// }