using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter your number :");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number it can be divided by 5 and 7 without reminder");
        }
        else
        {
            Console.WriteLine("The number it can't be divided without reminder ");
        }
    }
}

