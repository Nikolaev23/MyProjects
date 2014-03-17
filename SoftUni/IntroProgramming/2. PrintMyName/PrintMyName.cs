// Create C# program which print my name .
using System;

class PrintMyName
{
    static void Main()
    {
        Console.WriteLine("Enter your first name :");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name :");
        string lastName = Console.ReadLine();

        string allName = firstName + " " + lastName;
        Console.WriteLine("Your name is : {0}",allName);
    }
}

