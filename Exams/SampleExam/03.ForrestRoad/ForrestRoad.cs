using System;

class ForrestRoad
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int height = (2 * width) - 1;
        
        for (int row = 1; row <= width; row++)
        {
            for (int col = 1; col <= width; col++)
            {
                if (row == col)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
        for (int row = width - 1; row > 0; row--)
        {
            for (int col = 1; col <= width; col++)
            {
                if (row != col)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
