/* Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.*/
using System;

class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter number :");
        int number = int.Parse(Console.ReadLine());
        int p = 3;
        int numberRightP = number >> p;
        int bit = numberRightP & 1;
        Console.WriteLine(bit);
    }
}

