//String and Object concatenation with casting.
using System;

class StringConcatenation
{
    static void Main()
    {
        string firstVariable = "Hello";
        string secondVariable = "World";
        Object stringConcatenation = firstVariable + " " + secondVariable;
        Console.WriteLine(stringConcatenation);

        string thirdVariable = (string)stringConcatenation;
        Console.WriteLine(thirdVariable);
    }
}

