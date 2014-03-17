//Quoted Strings.
using System;

class QuotedStrings
{
    static void Main()
    {
        string firstVariable = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("Without quoted strings : {0} ",firstVariable);
        string secondVariable = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("With quoted strings : {0}",secondVariable);
    }
}

