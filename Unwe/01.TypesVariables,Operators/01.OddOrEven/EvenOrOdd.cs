using System;

class EvenOrOdd
{
    static void Main()
    {
        Console.WriteLine("Enter your number :");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number {0} is Even",number);
        }
        else
        {
            Console.WriteLine("The number {0} is Odd",number);
        }
    }
}

