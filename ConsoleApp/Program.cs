using System;
using StringExtensions;  // Import the namespace for the extension method

class Program
{
    static void Main()
    {
        // Test the extension method
        string testString = "Hello";

        bool result = testString.StartsWithUpperCase();  // Use the extension method

        Console.WriteLine($"Does the string start with an uppercase letter? {result}");
    }
}


