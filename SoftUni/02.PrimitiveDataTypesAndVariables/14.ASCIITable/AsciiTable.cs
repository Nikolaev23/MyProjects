//Ascii table.
using System;

class AsciiTable
{
    static void Main(string[] args)
    {
        Console.WriteLine("ASCII Table :");

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("Number {0} equals symbol {1}",i,(char)i);
            
        }
    }
}

