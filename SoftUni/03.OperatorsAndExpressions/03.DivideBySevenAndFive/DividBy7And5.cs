/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.*/
using System;

class DividBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter your number :");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number it can be divided without reminder by 7 and 5 !");
        }
        else
        {
            Console.WriteLine("The number it can't be divided without reminder!");
        }
    }
}

