//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
using System;

class PrintLongSequance
{
    static void Main()
    {
        Console.BufferHeight = 1001;
        for (int i = 2; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(-i);
            }
        }
    }
}

