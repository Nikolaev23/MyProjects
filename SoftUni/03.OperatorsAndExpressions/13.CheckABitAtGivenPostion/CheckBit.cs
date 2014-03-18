/* Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. */
using System;

class CheckBit
{
    static void Main()
    {
        Console.WriteLine("Enter number :");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position :");
        int p = int.Parse(Console.ReadLine());
        int numberRightP = number >> p;
        int bit = numberRightP & 1;
        bool isBitOne = true;
        if (bit == 1)
        {
            Console.WriteLine(isBitOne);
        }
        else
        {
            Console.WriteLine(isBitOne = false);
        }
    }
}

