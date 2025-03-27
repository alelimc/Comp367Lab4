using System;
using UtilityLibraries;

class Program
{
    static void Main()
    {
        string testString = "Hello World";
        Console.WriteLine($"'{testString}' starts with uppercase: {testString.StartsWithUpper()}");

        string testString2 = "hello world";
        Console.WriteLine($"'{testString2}' starts with uppercase: {testString2.StartsWithUpper()}");
    }
}
