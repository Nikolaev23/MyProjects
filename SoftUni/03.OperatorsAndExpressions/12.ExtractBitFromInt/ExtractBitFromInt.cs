using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.WriteLine("Enter number :");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position :");
        int p = int.Parse(Console.ReadLine());
        int numberRightP = number >> p;
        int bit = numberRightP & 1;
        Console.WriteLine("Bit : {0}",bit);
    }
}

