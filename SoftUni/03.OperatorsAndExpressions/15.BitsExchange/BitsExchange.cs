using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter your number :");
        uint number = uint.Parse(Console.ReadLine());
        int possitionFirstSeq = 3;
        int possitionSecondSeq = 24;
        uint firstSeqRight;
        uint secondtSeqRight;
        int bitFirstSeq;
        int bitSecondSeq;
        for (int i = 0; i < 3; i++)
        {
            firstSeqRight = number >> possitionFirstSeq;
            secondtSeqRight = number >> possitionSecondSeq;
            bitFirstSeq = (int)(firstSeqRight & 1);
            bitSecondSeq = (int)(secondtSeqRight & 1);
            if (bitFirstSeq != bitSecondSeq)
            {
                if (bitFirstSeq == 1)
                {
                    number = (uint)(number & (~(1 << possitionFirstSeq)));
                    number = (uint)(number | (1 << possitionSecondSeq));
                }
                else
                {
                    number = (uint)(number | (1 << possitionFirstSeq));
                    number = (uint)(number & (~(1 << possitionSecondSeq)));
                }
            }
            possitionFirstSeq++;
            possitionSecondSeq++;
        }
        Console.WriteLine("The number after change is: {0}.", number);
    }
}

